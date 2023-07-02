using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace ExConPram.Main
{
    /// <summary>
    /// Подключение для MsSql
    /// </summary>    
    /// <remarks>Тестировался на NuGet >> Microsoft.Data.SqlClient 5.1.1</remarks>   
    public class MsSql_Commander : ISQLCommander
    {
        private bool ConnectIsField = false;
        private SqlConnection MSSQL;

        public ISQLCommander.TypeSqlConnection SqlType { get; } = ISQLCommander.TypeSqlConnection.MSSQL;
        /// <summary>
        /// Имя сервера не работает с локальной базой данных. Требуется для сервера
        /// </summary>
        public string Server_conString { get; set; } = "MAINFRAME";
        /// <summary>
        /// SQL Connect для строки подключения, вам нужно имя базы данных на сервере, который уже создан
        /// </summary>
        public string Database_conString { get; set; } = "TestBase";
        /// <summary>
        /// Логин для сервера MSSql
        /// </summary>
        public string UserId_con { get; set; } = "sa";
        /// <summary>
        /// Пароль для сервера MSSql
        /// </summary>
        public string Password_con { get; set; } = "1000";
        /// <summary>
        /// Multiple Active Result Sets (MARS) 
        /// </summary>
        /// <remarks>Разрешает несколько подключений к серверу</remarks>
        public bool MultipleActiveResultSets { get; set; } = true;
        /// <summary>
        /// Получает или задает значение, указывающее, будет ли канал зашифрован
        /// при обходе цепочки сертификатов для проверки доверия.
        /// </summary>
        public bool TrustServerCertificate { get; set; } = true;

        public bool ConnectIs
        {
            get
            {
                if (MSSQL.State == System.Data.ConnectionState.Broken) ConnectIsField = false;
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
                pol = $"SELECT * FROM [{tabelName}] WHERE " + where;
            }
            else
            {
                pol = $"SELECT * FROM [{tabelName}]";
            }
            SqlCommand command = new SqlCommand(pol, MSSQL);
            using (SqlDataReader sqReader = command.ExecuteReader())
            {
                while (sqReader.Read())
                {
                    object[] obj = new object[sqReader.FieldCount];
                    for (int i = 0; i < sqReader.FieldCount; i++)
                    {
                        obj[i] = sqReader.GetValue(i);
                    }
                    ls.Add(obj);
                }
            }
            return ls;
        }
        public bool CheckExistTabel(string tabelName)
        {
            if (ConnectIs == false) { throw new Exception("No database connection [" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]"); }
            SqlCommand command = new SqlCommand("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '" + tabelName + "'", MSSQL);
            SqlDataReader sqReader = command.ExecuteReader();
            sqReader.Read();
            bool d = sqReader.HasRows;
            sqReader.Close();
            return d;
        }
        public List<T> CollectionList<T>(string WHERE_sql)
        {
            if (ConnectIs == false) { throw new Exception("No database connection [" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]"); }
            List<T> ls = new List<T>();
            Type genericType = typeof(T);

            SqlCommand command = new SqlCommand($"SELECT ID FROM {genericType.Name} WHERE " + WHERE_sql, MSSQL);
            using (SqlDataReader sqReader = command.ExecuteReader())
            {
                while (sqReader.Read())
                {
                    object dbClass = Activator.CreateInstance(genericType); // создет новый экземпляр                            
                    dbClass.GetType().GetMethod("GetDate").Invoke(dbClass, new object[] { int.Parse(sqReader.GetValue(0).ToString()), this });
                    ls.Add((T)dbClass);
                }
            }

            return ls;
        }

        public void Connect()
        {
            MSSQL = new SqlConnection
            {
                ConnectionString = $"Server={Server_conString}; Database={Database_conString}; User Id={UserId_con}; Password={Password_con};" +
                $"MultipleActiveResultSets={MultipleActiveResultSets}; TrustServerCertificate={TrustServerCertificate};"
            };
            try
            {
                MSSQL.Open();
                ConnectIsField = true;
            }
            catch (Exception Ex)
            {
                ConnectIsField = false;
                MSSQL.Dispose();
                throw Ex;
            }
        }
        public void Delete(string tabelName, int id) => SqlCommand($"DELETE FROM [{tabelName}] WHERE ID = {id}");
        public void Disconnect() => MSSQL.Close();

        public Dictionary<string, object> GetDate(int ID, string TabelName)
        {
            if (ID == -1) { throw new Exception("ID = -1 not exist [" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]"); }
            Dictionary<string, object> dic = new Dictionary<string, object>();

            SqlCommand command = new SqlCommand($"SELECT * FROM [{TabelName}] WHERE ID={ID}", MSSQL);
            SqlDataReader sqReader = command.ExecuteReader();
            using (sqReader)
            {
                sqReader.Read();
                if (sqReader.FieldCount == 0) return null;
                for (int i = 0; i < sqReader.FieldCount; i++)
                {
                    dic.Add(sqReader.GetName(i), sqReader.GetValue(i));
                }
            }
            return dic;
        }

        public Dictionary<string, string> GetNames(string TabelName)
        {
            if (ConnectIs == false) { throw new Exception("No database connection [" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]"); }
            SqlCommand command = new SqlCommand("SELECT TOP (1) * FROM [" + TabelName + "]", MSSQL);
            SqlDataReader sqReader = command.ExecuteReader();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            sqReader.Read();
            for (int i = 0; i < sqReader.FieldCount; i++)
            {
                string name = sqReader.GetName(i);
                int cut = sqReader.GetDataTypeName(i).IndexOf(" (");
                string TypeName = sqReader.GetDataTypeName(i).Substring(0, (cut == -1) ? sqReader.GetDataTypeName(i).Length : cut);
                dic.Add(name, TypeName);
            }
            sqReader.Close();
            return dic;
        }

        public int SqlCommand(string sql)
        {
            if (ConnectIs == false) { throw new Exception("No database connection [" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]"); }
            try
            {
                SqlCommand command = MSSQL.CreateCommand();
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
            string parametors="";
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
                "Boolean" => "BIT",
                "KEY_ID" => "INT IDENTITY (0, 1) PRIMARY KEY",
                _ => $"VARCHAR {parametors}"
            };           
        }
    }
}
