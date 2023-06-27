using System;
using System.Collections.Generic;
using System.Data.SQLite;


namespace ExConPram.Main
{
    /// <summary>
    /// Соеденение с Sqlite
    /// </summary>
    /// <remarks>Тестировался на NuGet >> System.Data.SQLite.Core 1.0.118</remarks>
    public class Sqlite_Commander : ISQLCommander
    {
        private bool ConnectIsField = false;
        private SQLiteConnection SQLite;

        /// <summary>
        /// Локальное размещение базы данных
        /// </summary>
        public string LocalDB { get; set; } = AppContext.BaseDirectory + "DataBaseMain.db";
        public bool ConnectIs
        {
            get
            {
                if (SQLite.State == System.Data.ConnectionState.Broken) ConnectIsField = false;
                return ConnectIsField;
            }
        }

        public void Connect()
        {
            SQLite = new SQLiteConnection();
            SQLiteConnectionStringBuilder stringBuilder = new SQLiteConnectionStringBuilder() { DataSource = LocalDB };
            SQLite.ConnectionString = stringBuilder.ToString();
            try
            {
                SQLite.Open();
                ConnectIsField = true;
            }
            catch (Exception Ex)
            {
                ConnectIsField = false;
                SQLite.Dispose();
                throw Ex;
            }
        }
        public void Delete(string tabelName, int id) => SqlCommand($"DELETE FROM {tabelName} WHERE ID = {id}");
        public void Disconnect() => SQLite.Close();

        public List<object[]> AdapterSql(string tabelName, string where = "")
        {
            List<object[]> ls = new List<object[]>();
            string pol;
            if (where != "")
            {
                pol = $"SELECT * FROM [{tabelName}] WHERE "+ where;
            }
            else
            {
                pol = $"SELECT * FROM [{tabelName}]";
            }
            SQLiteCommand command = new SQLiteCommand(pol, SQLite);
            using (SQLiteDataReader sqReader = command.ExecuteReader())
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
        public List<T> CollectionList<T>(string WHERE_sql)
        {
            List<T> ls = new List<T>();
            Type genericType = typeof(T);

            SQLiteCommand command = new SQLiteCommand($"SELECT ID FROM {genericType.Name} WHERE " + WHERE_sql, SQLite);
            using (SQLiteDataReader sqReader = command.ExecuteReader())
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
        public Dictionary<string, string> GetNames(string TabelName)
        {
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM '" + TabelName + "' LIMIT 1", SQLite);
            SQLiteDataReader sqReader = command.ExecuteReader();
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
        public Dictionary<string, object> GetDate(int ID, string TabelName)
        {
            if (ID == -1) { throw new Exception("ID = -1 not exist [" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]"); }
            Dictionary<string, object> dic = new Dictionary<string, object>();

            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{TabelName}] WHERE ID={ID}", SQLite);
            SQLiteDataReader sqReader = command.ExecuteReader();
            using (sqReader)
            {
                sqReader.Read();
                if (sqReader.StepCount == 0) return null;
                for (int i = 0; i < sqReader.FieldCount; i++)
                {
                    dic.Add(sqReader.GetName(i), sqReader.GetValue(i));
                }
            }
            return dic;
        }
        public int SqlCommand(string sql)
        {
            if (ConnectIs == false) { throw new Exception("No database connection [" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]"); }
            try
            {
                SQLiteCommand command = SQLite.CreateCommand();
                command.CommandText = sql;
                return command.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public bool CheckExistTabel(string tabelName)
        {
            if (ConnectIs == false) { throw new Exception("No database connection [" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]"); }
            SQLiteCommand command = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type='table' AND name='" + tabelName + "'", SQLite);
            SQLiteDataReader sqReader = command.ExecuteReader();
            sqReader.Read();
            bool d = sqReader.HasRows;
            sqReader.Close();
            return d;
        }       
        public string TypeSQL(System.Reflection.PropertyInfo info) => info.PropertyType.Name switch
        {
            "Decimal" => "NUMERIC",
            "Int16" => "INTEGER",
            "Int32" => "INTEGER",
            "Short" => "INTEGER",
            "Fload" => "REAL",
            "Double" => "REAL",
            _ => "TEXT"
        };
               
    }
}
