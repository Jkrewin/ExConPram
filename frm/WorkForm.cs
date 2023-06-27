using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExConPram.frm
{
    /// <summary>
    /// Обеспецивает взаимодействие с WinForm как ISQLCommander и ClassDBParam
    /// </summary>
    static class WorkForm
    {
        static private List<Control> ControlList;

        /// <summary>
        /// Заполняет Form этим классов, только те контролы которые имеют Name как в этом классе
        /// </summary>
        /// <param name="frm">тут форма</param>
        /// <param name="obj">тут класс</param>
        static public void FillForm(Form frm, object obj)
        {
            ControlList = new List<Control>();
            GetAllControls(frm);

            foreach (var item in obj.GetType().GetProperties())
            {
                foreach (Control tv in ControlList)
                {
                    if (item.Name == tv.Name)                      // Тут обработка контрола
                    {
                        if (tv.GetType().Name == "TextBox")
                        {
                            ((TextBox)tv).Text = Convert.ToString(item.GetValue(obj));
                        }
                        else if (tv.GetType().Name == "ComboBox")
                        {
                            if (item.PropertyType.IsEnum == false)
                            {
                                ((ComboBox)tv).Text = Convert.ToString(item.GetValue(obj));
                            }
                            else
                            {
                                try
                                {
                                    ((ComboBox)tv).SelectedIndex = (int)Enum.Parse(item.PropertyType, item.GetValue(obj).ToString());
                                }
                                catch (Exception ex) 
                                {
                                    throw new Exception("Проверте ComboBox " + tv.Name + " возможно оно не заполнено. " + ex.Message);
                                }
                            }
                        }
                        else if (tv.GetType().Name == "NumericUpDown")
                        {
                            ((NumericUpDown)tv).Value = Convert.ToDecimal(item.GetValue(obj));
                        }
                        else if (tv.GetType().Name == "Label")
                        {
                            ((Label)tv).Text = Convert.ToString(item.GetValue(obj));
                        }
                        else if (tv.GetType().Name == "CheckBox")
                        {
                            ((CheckBox)tv).Checked = Convert.ToBoolean(item.GetValue(obj));
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Обновляет класс из данных формы
        /// </summary>
        /// <param name="frm">тут форма</param>
        /// <param name="obj">тут класс</param>
        static public void GetDataObj(Form frm, object obj)
        {
            ControlList = new List<Control>();
            GetAllControls(frm);

            var dic = DataBase.ClassDBParam.SQL_Elements(obj);
            //выбираем те которые можно записать 
            var prop = (from tv in obj.GetType().GetProperties()
                        where tv.CanWrite == true
                        select tv as System.Reflection.PropertyInfo).ToList();

            foreach (var item in prop)
            {
                Control control = ControlList.Find(x => x.Name.ToLower() == item.Name.ToLower());
                if (control == null) continue;
                string refObj = control.GetType().Name switch
                {
                    "TextBox" => ((TextBox)control).Text,
                    "ComboBox" => ((ComboBox)control).Text,
                    "NumericUpDown" => ((NumericUpDown)control).Value.ToString(),
                    "Label" => ((Label)control).Text,
                    "CheckBox" => ((CheckBox)control).Checked.ToString(),
                    _ => "0",
                };

                // Конвертатор
                // добавить если будут другие типы данных
                if (item.PropertyType.IsEnum)
                {
                    item.SetValue(obj, Enum.Parse(item.PropertyType, refObj));
                    continue;
                }

                switch (item.PropertyType.Name)
                {
                    case "Int16":
                        item.SetValue(obj, Int16.Parse(refObj));
                        break;
                    case "Int32":
                        item.SetValue(obj, Int32.Parse(refObj));
                        break;
                    case "Int64":
                        item.SetValue(obj, Int64.Parse(refObj));
                        break;
                    case "Decimal":
                        item.SetValue(obj, decimal.Parse(refObj));
                        break;
                    case "Boolean":
                        item.SetValue(obj, Boolean.Parse(refObj));
                        break;
                    default:
                        item.SetValue(obj, refObj);
                        break;
                }
            }
        }
        /// <summary>
        /// Загрузить список DeliveredClass.
        /// </summary>
        /// <param name="tabelName"></param>
        /// <param name="nameCol"></param>
        /// <param name="comboBox"></param>
        static public void GetDataComboBox(string tabelName, string nameCol, ComboBox comboBox, Main.ISQLCommander SQLCommander, string search = "")
        {
            comboBox.DataSource = null; // важно обнулить сначало иначе данные не обновяться             
            int i = 0;
            int id_index = 0;
            int nameCol_index = 0;

            foreach (var item in SQLCommander.GetNames(tabelName))
            {
                if (item.Key == "ID") { id_index = i; }
                else if (item.Key.ToLower() == nameCol.ToLower()) { nameCol_index = i; }
                i++;
            }

            List<object[]> ls;
            if (search == "")
            {
                ls = SQLCommander.AdapterSql(tabelName, $" ActiveObjIsDelete ='False'");
            }
            else
            {
                ls = SQLCommander.AdapterSql(tabelName, $" ActiveObjIsDelete ='False' AND lower({nameCol}) LIKE '%{search.ToLower()}%'");
            }

            DeliveredClass[] delivereds = new DeliveredClass[ls.Count];
            i = 0;
            foreach (var item in ls)
            {
                delivereds[i] = new DeliveredClass()
                {
                    Id = (int)(long)item[id_index],
                    Name = (string)item[nameCol_index],
                    TabelName = tabelName
                };
                i++;
            }
            comboBox.DataSource = delivereds;
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";
        }
        /// <summary>
        /// Проверит TextBox на наличие требований длинны строки и типа данных исходя из SqlReq
        /// </summary>
        /// <param name="tbox">навание TextBox полжно совпадасть с наванием объектов в классе</param>
        static public void NormalizationTextBox(TextBox textBox, object obj)
        {
            textBox.BackColor = System.Drawing.Color.White;
            Dictionary<string, DataBase.ISqlField> dic = DataBase.ClassDBParam.SQL_Elements(obj);
            if (dic.ContainsKey(textBox.Name) == false) return;
            DataBase.SqlReq sqlReq = (DataBase.SqlReq)dic[textBox.Name];

            if (sqlReq.MinValue != -1)
            {
                if (textBox.Text.Length < sqlReq.MinValue)
                {
                    textBox.BackColor = System.Drawing.Color.Honeydew;
                }
            }

            if (sqlReq.MaxValue != -1)
            {
                textBox.MaxLength = sqlReq.MaxValue;
                if (textBox.Text.Length > sqlReq.MaxValue)
                {
                    textBox.Text = textBox.Text.Substring(0, sqlReq.MaxValue);
                }
            }

            // Делает исключения для типов которые могут содержат символы или текст
            switch (obj.GetType().GetProperty(textBox.Name).PropertyType.Name)
            {
                case "String":
                case "Char":
                    break;
                default:
                    // оставить только цифры
                    textBox.Text = textBox.Text.Replace(".", ",");
                    textBox.Text = System.Text.RegularExpressions.Regex.Replace(textBox.Text, @"[^0-9,]+", String.Empty);
                    break;
            }
        }
        /// <summary>
        /// Проверка получаемых данны на соответствие с требованиями 
        /// </summary>
        /// <param name="obj">Объект который нужно проверить </param>
        /// <returns>true - означает что соотвествует </returns>
        static public bool DataValidator(object obj)
        {
            string deep = "";
            var dic = DataBase.ClassDBParam.SQL_Elements(obj);

            //выбираем те которые можно записать 
            var prop = (from tv in obj.GetType().GetProperties()
                        where tv.CanWrite == true
                        select tv as System.Reflection.PropertyInfo).ToList();

            foreach (var item in prop)
            {
                Control control = ControlList.Find(x => x.Name.ToLower() == item.Name.ToLower());
                if (control == null) continue;
                control.BackColor = System.Drawing.Color.WhiteSmoke;
                string refObj;
                switch (control.GetType().Name)
                {
                    case "TextBox":
                        refObj = ((TextBox)control).Text;
                        break;
                    case "ComboBox":
                        if (item.PropertyType.IsEnum == false) { refObj = ((ComboBox)control).Text; }
                        else
                        { refObj = Enum.Parse(item.PropertyType, ((ComboBox)control).SelectedIndex.ToString()).ToString(); }
                        break;
                    case "NumericUpDown":
                        refObj = ((NumericUpDown)control).Value.ToString();
                        break;
                    case "Label":
                        refObj = ((Label)control).Text;
                        break;
                    case "CheckBox":
                        refObj = ((CheckBox)control).Checked.ToString();
                        break;
                    default:
                        refObj = "0";
                        break;
                }
                //Валидатор данных
                if (dic[control.Name] is DataBase.SqlReq)
                {
                    var v = dic[control.Name] as DataBase.SqlReq;
                    if (item.PropertyType.Name == "Boolean")
                    {
                        if (refObj.ToLower() == "true" & refObj.ToLower() == "false" & refObj == "0" & refObj == "1")
                        {
                            deep += "Поле " + item.Name + " не содержит логический символ. \n";
                            control.BackColor = System.Drawing.Color.LightCoral;
                        }
                        continue;
                    }
                    else if (item.PropertyType.IsEnum)
                    {

                    }
                    else if (item.PropertyType.Name != "String" & item.PropertyType.Name != "Char")
                    {
                        if (refObj.All(char.IsDigit) == false)
                        {
                            deep += "Поле " + item.Name + " может содержать только цифры \n";
                            control.BackColor = System.Drawing.Color.LightCoral;
                        }
                    }

                    if (v.MinValue != -1)
                    {
                        if (refObj.Length < v.MinValue)
                        {
                            deep += "Поле " + item.Name + " должно содержать не меньше " + v.MinValue + " символов. \n";
                            control.BackColor = System.Drawing.Color.LightCoral;
                        }
                    }

                    if (v.MaxValue != -1)
                    {
                        if (refObj.Length > v.MaxValue)
                        {
                            deep += "Поле " + item.Name + " привышает максимальное количество символов: " + v.MaxValue + " символов. \n";
                            control.BackColor = System.Drawing.Color.LightCoral;
                        }
                    }
                }
            }
            if (deep != "")
            {
                MessageBox.Show(deep);
                return false;
            }
            return true;
        }
        /// <summary>
        /// Находит все элементы управления в форме
        /// </summary>        
        static private void GetAllControls(Control container)
        { //Finds all controls on a form
            foreach (Control item in container.Controls)
            {
                GetAllControls(item);
                ControlList.Add(item);
            }
        }


        /// <summary>
        /// Просто нужен для списков в контролах
        /// </summary>
        public class DeliveredClass
        {
            public string Name { get; set; }
            public int Id { get; set; }
            public string TabelName { get; set; }
        }
    }
}
