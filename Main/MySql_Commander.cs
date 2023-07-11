using System;
using System.Collections.Generic;using MySql.Data.MySqlClient;

namespace ExConPram.Main
{
    /// <summary>
    /// Подключение для MySql
    /// </summary>    
    /// <remarks>Тестировался на NuGet >> MySql.Data 8.0.33</remarks>   
    public class MySql_Commander : ISQLCommander
    {
        private bool ConnectIsField = false;
        private MySqlConnection MySQL;        

        public ISQLCommander.TypeSqlConnection SqlType { get; } = ISQLCommander.TypeSqlConnection.MySQL;
        /// <summary>
        /// Имя сервера не работает с локальной базой данных. Требуется для сервера
        /// </summary>
        public string Server_IP_Mysql { get; set; } = "192.168.1.66";
        /// <summary>
        /// SQL Connect для строки подключения, вам нужно имя базы данных на сервере, который уже создан
        /// </summary>
        public string Database_Mysql { get; set; } = "new_schema";
        /// <summary>
        /// Логин для сервера 
        /// </summary>
        public string UserId_Mysql { get; set; } = "sa";
        /// <summary>
        /// Пароль для сервера 
        /// </summary>
        public string Password_Mysql { get; set; } = "1000";        

        public bool ConnectIs
        {
            get
            {
                if (MySQL.State == System.Data.ConnectionState.Broken) ConnectIsField = false;
                return ConnectIsField;
            }
        }

        public List<object[]> AdapterSql(string tabelName, string where = "")
        {
            if (ConnectIs == false) { throw new Exception("No database connection [" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]"); }
            List<object[]> ls = new List<object[]>();
            string pol;
            if (where != "")
            {
                pol = $"SELECT * FROM `{tabelName}` WHERE " + where;
            }
            else
            {
                pol = $"SELECT * FROM `{tabelName}`";
            }
            MySqlCommand command = new MySqlCommand(pol, MySQL);
            using (MySqlDataReader sqReaderSQL = command.ExecuteReader())
            {
                while (sqReaderSQL.Read())
                {
                    object[] obj = new object[sqReaderSQL.FieldCount];
                    for (int i = 0; i < sqReaderSQL.FieldCount; i++)
                    {
                        obj[i] = sqReaderSQL.GetValue(i);
                    }
                    ls.Add(obj);
                }
            }
            return ls;
        }
        public bool CheckExistTabel(string tabelName)
        {
            if (ConnectIs == false) { throw new Exception("No database connection [" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]"); }
            MySqlCommand command = new MySqlCommand("SHOW TABLES LIKE '" + tabelName + "'", MySQL);
            MySqlDataReader sqReaderSQL = command.ExecuteReader();
            sqReaderSQL.Read();
            bool d = sqReaderSQL.HasRows;
            sqReaderSQL.Close();
            return d;
        }
        public List<T> CollectionList<T>(string WHERE_sql)
        {
            if (ConnectIs == false) { throw new Exception("No database connection [" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]"); }
            List<T> ls = new List<T>();
            Type genericType = typeof(T);
            List<int> vs = new List<int>();

            MySqlCommand command = new MySqlCommand($"SELECT ID FROM {genericType.Name} WHERE " + WHERE_sql, MySQL);
            using (MySqlDataReader sqReaderSQL = command.ExecuteReader())
            {
                while (sqReaderSQL.Read())
                {
                    vs.Add(int.Parse(sqReaderSQL.GetValue(0).ToString()));                 
                }                
            }
            // mysql неподерживает несколько MySqlDataReader, поэтому в отдельный список
            foreach (int i in vs)
            {
                object dbClass = Activator.CreateInstance(genericType); // создет новый экземпляр                            
                dbClass.GetType().GetMethod("GetDate").Invoke(dbClass, new object[] { i, this });
                ls.Add((T)dbClass);
            }

            return ls;
        }

        public void Connect()
        {
            MySQL = new MySqlConnection { ConnectionString = $"Server={Server_IP_Mysql}; Database={Database_Mysql}; User Id={UserId_Mysql}; Password={Password_Mysql}; " };
            try
            {
                MySQL.Open();
                ConnectIsField = true;
            }
            catch (Exception Ex)
            {
                ConnectIsField = false;
                MySQL.Dispose();
                throw Ex;
            }
        }
        public void Delete(string tabelName, int id) => SqlCommand($"DELETE FROM `{tabelName}` WHERE ID = {id}");
        public void Disconnect() => MySQL.Close();

        public Dictionary<string, object> GetDate(int ID, string TabelName)
        {
            if (ID == -1) { throw new Exception("ID = -1 not exist `" + System.Reflection.MethodBase.GetCurrentMethod().Name + "`"); }
            Dictionary<string, object> dic = new Dictionary<string, object>();

            MySqlCommand command = new MySqlCommand($"SELECT * FROM `{TabelName}` WHERE ID={ID}", MySQL);
            MySqlDataReader sqReaderSQL = command.ExecuteReader();
            using (sqReaderSQL)
            {
                sqReaderSQL.Read();
                if (sqReaderSQL.FieldCount == 0) return null;
                for (int i = 0; i < sqReaderSQL.FieldCount; i++)
                {
                    dic.Add(sqReaderSQL.GetName(i), sqReaderSQL.GetValue(i));
                }
            }
            sqReaderSQL.Close();
            return dic;
        }
        public Dictionary<string, string> GetNames(string TabelName)
        {
            if (ConnectIs == false) { throw new Exception("No database connection [" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]"); }
            MySqlCommand command = new MySqlCommand("SELECT * FROM `" + TabelName + "` LIMIT 1", MySQL);
            MySqlDataReader sqReaderSQL = command.ExecuteReader();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            sqReaderSQL.Read();
            for (int i = 0; i < sqReaderSQL.FieldCount; i++)
            {
                string name = sqReaderSQL.GetName(i);
                int cut = sqReaderSQL.GetDataTypeName(i).IndexOf(" (");
                string TypeName = sqReaderSQL.GetDataTypeName(i).Substring(0, (cut == -1) ? sqReaderSQL.GetDataTypeName(i).Length : cut);
                dic.Add(name, TypeName);
            }
            sqReaderSQL.Close();
            return dic;
        }

        public int SqlCommand(string sql)
        {
            if (ConnectIs == false) { throw new Exception("No database connection [" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]"); }
            try
            {
                MySqlCommand command = MySQL.CreateCommand();
                command.CommandText = sql;
                return command.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public string TypeSQL(string info, DataBase.SqlReq sqlReq)
        {
            string parametors = "";
            if (sqlReq != null)
            {
                parametors = "(" + sqlReq.MaxValue.ToString() + ")";
                if (sqlReq.Parametor != "") parametors = sqlReq.Parametor;
            }

            return info switch
            {
                "Decimal" => "DECIMAL",
                "Int16" => "SMALLINT",
                "Int32" => "INT",
                "Short" => "SMALLINT",
                "Fload" => "FLOAT",
                "Double" => "REAL",
                "Boolean" => "BOOL",
                "KEY_ID" => "INT PRIMARY KEY AUTO_INCREMENT",
                _ => $"VARCHAR {parametors}"
            };
        }
    }
}
