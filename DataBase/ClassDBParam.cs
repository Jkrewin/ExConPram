using System;
using System.Collections.Generic;
using System.Linq;

namespace ExConPram.DataBase
{

    /// <summary>
    /// Используеться для взаимодействии с БД 
    /// </summary>
    public abstract class ClassDBParam
    {
        public string TabelName { get => this.GetType().Name; }
        private int IDField = -1;

        /// <summary>
        /// ID в базе данных. -1 не в бд будет созданно ид когда эта строка будет внесена в бд            
        /// </summary>
        [SqlReq("KEY_ID", "")]
        public int ID { get { return IDField; } }
        /// <summary>
        /// Помечено на удаление или не актуально
        /// </summary>
        [SqlReq()]
        public bool ActiveObjIsDelete { get; set; } = false;

        /// <summary>
        /// Cоздает запрос на создание таблици        
        /// </summary>
        /// <remarks>Есть проверка на существование таблици, если существует то запроса не будет</remarks>
        public void CreateTabel(Main.ISQLCommander SQLCommander)
        {
            // Существует такая БД или нет 
            if (SQLCommander.CheckExistTabel(TabelName)) return;

            string str = "CREATE TABLE [" + TabelName + "] (";
            foreach (var item in SQL_Elements(this))
            {
                if (item.Value is SqlReq)               // из несколькоих атрибутов нужен только SqlReq 
                {
                    var Req = item.Value as SqlReq;
                    string Datatype = string.Empty;

                    if (item.Value.Type_Param == "KEY_ID") { Datatype = SQLCommander.TypeSQL("KEY_ID",Req); }
                    else if (item.Value.Type_Param != "") { Datatype = SQLCommander.TypeSQL(item.Value.Type_Param, Req);  }
                    else { Datatype = SQLCommander.TypeSQL(this.GetType().GetProperty(item.Key).PropertyType.Name, Req); }

                    str += $"[{item.Key}] {Datatype} , ";                     
                }
                else if (item.Value is SqlReqObj)       // для класса или структуры
                {
                    str += $"[{item.Key}] INT DEFAULT(-1), ";
                }
            }
            str = str[0..^2] + ") ";
            SQLCommander.SqlCommand(str);
        }
        /// <summary>
        /// Обновить данные в базе 
        /// </summary>
        public void Update(Main.ISQLCommander SQLCommander)
        {
            Dictionary<string, ISqlField> dic = SQL_Elements(this);
            dic.Remove("ID");           //Так как автоматическая строка

            if (IDField == -1)          //Создание новой строки 
            {
                string str = "";
                string values = "";

                foreach (var item in dic)
                {
                    str += "[" + item.Key + "], ";
                    System.Reflection.PropertyInfo refl = this.GetType().GetProperty(item.Key);
                    if (item.Value is SqlReq)
                    {
                        values += "'" + CastType(refl.GetValue(this), refl) + "', ";
                    }
                    else            // Если это класс
                    {
                        //сначало проверми есть в этом классе ID некоторые классы не сохраняються в БД без ID                                                                    
                        var classDB = (ClassDBParam)refl.GetValue(this);
                        if (classDB != null) { values += "'" + classDB.ID + "', "; }
                        else { values += "'-1', "; }
                    }
                }

                str = str[0..^2];
                values = values[0..^2];

                IDField = SQLCommander.SqlCommand($"INSERT INTO  [{TabelName}] ({str}) VALUES ({values})");
            }
            // изменение строки 
            else
            {
                string unityValue = "";
                foreach (var item in dic)
                {
                    System.Reflection.PropertyInfo refl = this.GetType().GetProperty(item.Key);
                    if (item.Value is SqlReq)
                    {
                        unityValue += "[" + item.Key + "]='" + CastType(refl.GetValue(this), refl) + "', ";
                    }
                    else            // Если это класс
                    {
                        //сначало проверми есть в этом классе ID некоторые классы не сохраняються в БД без ID                                                                    
                        var classDB = (ClassDBParam)refl.GetValue(this);
                        if (classDB != null) { unityValue += $"[{item.Key}]='{classDB.ID}', "; }
                        else { unityValue += $"[{item.Key}]='', "; }
                    }
                }

                unityValue = unityValue[0..^2];
                SQLCommander.SqlCommand($"UPDATE [{TabelName}] SET {unityValue} WHERE ID = {ID}");
            }
        }
        /// <summary>
        /// подгружает данный из SQl базы
        /// </summary>
        /// <param name="ID"></param>
        public void GetDate(int id, Main.ISQLCommander SQLCommander)
        {
            if (id == -1) { return; }
            Dictionary<string, object> dic = SQLCommander.GetDate(id, TabelName);
            if (dic == null) { return; } //если нет строки или ошибка выход
            IDField = id;

            //выбираем те которые можно записать 
            var prop = (from tv in this.GetType().GetProperties() where tv.CanWrite == true & dic.ContainsKey(tv.Name) select tv as System.Reflection.PropertyInfo).ToList();
            foreach (var item in prop)
            {
                if (Attribute.GetCustomAttribute(item, typeof(SqlReqObj)) != null)              //тут разбор для SqlReqObj
                {
                    if ((int)dic[item.Name] == -1) continue;
                    // если несколько методов с одинаковым названием то следует искать первый так как последний скрыт new
                    var method = (from tv in item.PropertyType.GetMethods() where tv.Name == "GetDate" select tv).Cast<System.Reflection.MethodInfo>().ToList();
                    object dbClass = Activator.CreateInstance(item.PropertyType);
                    method.First().Invoke(dbClass, new object[] { dic[item.Name], SQLCommander });
                    item.SetValue(this, dbClass);
                }
                else if (Attribute.GetCustomAttribute(item, typeof(SqlReq)) != null)            //для  других  SqlReq
                {
                    // в особых случиях надо добовлять конвертацию данных вручную
                    if (item.PropertyType.IsEnum) { item.SetValue(this, Enum.Parse(item.PropertyType, dic[item.Name].ToString())); }
                    else if (item.PropertyType.Name == "Color") { item.SetValue(this, System.Drawing.Color.FromName(dic[item.Name].ToString())); }
                    else if (item.PropertyType.Name == "Boolean") { item.SetValue(this, bool.Parse(dic[item.Name].ToString())); }
                    else if (item.PropertyType.Name == "Int64") { item.SetValue(this, Int64.Parse(dic[item.Name].ToString())); }
                    else if (item.PropertyType.Name == "Int16") { item.SetValue(this, Int16.Parse(dic[item.Name].ToString())); }
                    else if (item.PropertyType.Name == "Int32") { item.SetValue(this, Int32.Parse(dic[item.Name].ToString())); }
                    else
                    {
                        item.SetValue(this, dic[item.Name]);
                    }
                }
            }
        }
        /// <summary>
        /// Проверяет соответствие класса и таблици в БД
        /// <c>Exception: Требует ConnectIs  подключение true</c>
        /// </summary>
        /// <param name="TabelName">Название таблици</param>
        /// <param name="obj">Класс или структура</param>
        /// <returns>true - соответствует </returns>
        public bool TableIntegrityCheck(Main.ISQLCommander SQLCommander)
        {
            if (SQLCommander.ConnectIs == false) { throw new Exception("No database connection [" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]"); }
            string deep = "";
            List<string> ls = new List<string>();

            foreach (var item in SQL_Elements(this)) //строка для сравнения
            {
                ls.Add(item.Key + SQLCommander.TypeSQL(this.GetType().GetProperty(item.Key).PropertyType.Name, null));
            }

            foreach (var item in SQLCommander.GetNames(TabelName))
            {
                if (ls.Exists(x => x.ToLower() == (item.Key + item.Value).ToLower()) == false)
                {
                    deep = deep + "Column structure does not match: " + item.Key + ":" + item.Value + "\n";
                }
            }
            if (deep != "") { throw new Exception(deep); }
            return deep == "";
        }
        /// <summary>
        /// Собирает данные в Dictionary от элементов содержащие CustomAttributes
        /// </summary>
        /// <param name="obj">Клас который содержить в себе ISqlField > CustomAttributes</param>
        /// <returns>ISqlField</returns>
        static public Dictionary<string, ISqlField> SQL_Elements(object obj)
        {
            Dictionary<string, ISqlField> element = new Dictionary<string, ISqlField>();
            foreach (var item in obj.GetType().GetProperties())
            {
                var atr = item.GetCustomAttributes(true);
                if (atr.Length != 0)                            // минимум один атрибут есть 
                {
                    foreach (object customAttr in atr)          // из несколькоих атрибутов нужен только SqlReq или SqlReqObj
                    {
                        if (customAttr is ISqlField)
                        {
                            element.Add(item.Name, customAttr as ISqlField);
                        }
                    }
                }
            }
            return element;
        }

        /// <summary>
        /// Преобразует к нужному типу.
        /// </summary>
        /// <param name="obj">получаемый из GetValue</param>
        /// <param name="info">this.GetType().GetProperty(item.Key)</param>
        /// <returns>string значение готовое для БД</returns>
        /// <remarks>Для некоторых особых случаев следует прописать преобразование к типу string</remarks>
        private string CastType(object obj, System.Reflection.PropertyInfo info)
        {
            string value = "";
            if (obj == null) return value;

            if (obj.GetType().IsEnum) { value = ((int)obj).ToString(); }
            else if (info.PropertyType.Name == "Color") { value = ((System.Drawing.Color)obj).Name; }
            else { value = obj.ToString(); }
            value.Replace("'", @"\'");

            return value;
        }
    }
}
