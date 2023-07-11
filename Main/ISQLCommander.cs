using System;
using System.Collections.Generic;

namespace ExConPram.Main
{
    /// <summary>
    /// Обеспечивает соеденение с разными sql БД 
    /// </summary>
    public interface ISQLCommander
    {
        /// <summary>
        /// Тип подключения к данных
        /// </summary>
        public TypeSqlConnection SqlType { get; }
        /// <summary>
        /// Проверяет подключена база данных или нет    
        /// </summary>
        /// <remarks>True - активное подключение</remarks>
        public bool ConnectIs { get; }
        /// <summary>
        /// Подключиться к базе данных
        /// </summary>
        public void Connect();
        /// <summary>
        /// Отключиться от БД
        /// </summary>
        public void Disconnect();       
        /// <summary>
        /// Првоерка на существование таблици
        /// </summary>
        /// <param name="tabelName">имя таб.</param>
        /// <returns>true - существует</returns>
        public bool CheckExistTabel(string tabelName);
        /// <summary>
        /// Получает значение название колоки и значение колоки 
        /// </summary>
        /// <param name="ID">id строки</param>
        /// <param name="TabelName">Название таблици</param>
        /// <returns></returns>
        public Dictionary<string, object> GetDate(int ID, string TabelName);
        /// <summary>
        /// Удаляет строку
        /// </summary>
        /// <param name="tabelName">Название таблици</param>
        /// <param name="id">id строки</param>
        public void Delete(string tabelName, int id);
        /// <summary>
        /// Выполняет SQL запрос
        /// </summary>
        /// <param name="sql">Строка запроса</param>
        /// <returns>Возврат Int добавленого id или измененного</returns>
        public int SqlCommand(string sql);
        /// <summary>
        /// Приведение типов к типам в Datatypes базе данных
        /// </summary>
        /// <param name="info">System.Reflection.PropertyInfo</param>
        /// /// <param name="sqlReq">Атрибуты  </param>
        /// <returns>Datatypes текущей БД</returns>
        public string TypeSQL(string str, DataBase.SqlReq sqlReq);
        /// <summary>
        /// Получает заголовки таблици название и тип данных Datatype
        /// </summary>
        /// <param name="TabelName">Название таблици</param>
        /// <returns>Dictionary<{Название таблици}, {Datatype}></returns>
        public Dictionary<string, string> GetNames(string TabelName);
        /// <summary>
        /// Создает коллекцию через запрос к БД 
        /// </summary>
        /// <typeparam name="T">Класс или структура которые существует в БД</typeparam>
        /// <param name="WHERE_sql">Запрос с требованиями sql который будет после WHERE </param>
        /// <returns>Колекция на основе Т</returns>
        /// <remarks>Запрос Select From автоматически собираються нужно только Where</remarks>
        public List<T> CollectionList<T>(string WHERE_sql);
        /// <summary>
        /// Cоздает запрос на создание таблици. 
        /// </summary>
        /// <typeparam name="T">Т только для ClassDBParam наследников</typeparam>
        /// <remarks>Этот метод фактически использует entity из T. Не имеет свой алгоритм</remarks>
        public void CreateTabel<T>()
        {
            Type genericType = typeof(T);
            object dbClass = Activator.CreateInstance(genericType);
            ((DataBase.ClassDBParam)dbClass).CreateTabel(this);
        }
        /// <summary>
        /// Получает List объектов по запросу или с правметрами поиска
        /// </summary>
        /// <param name="tabelName">Нзавание таблици</param>        
        /// <param name="where">Необязателен. Можно составить запрос после WHERE с поиском строк </param>
        /// <returns>Получает список объектов совместимых с ClassDBParam</returns>
        public List<object[]> AdapterSql(string tabelName, string where = "");

        /// <summary>
        /// Указывает какой тип подключения сейчас
        /// </summary>
        public enum TypeSqlConnection
        {
            /// <summary>
            /// <b>NuGet</b> >> Microsoft.Data.SqlClient
            /// </summary>
            MSSQL,
            /// <summary>
            /// <b>NuGet</b> >> System.Data.SQLite.Core 
            /// </summary>
            Sqlite,
            /// <summary>
            ///  NuGet >> MySql.Data 8.0.33
            /// </summary>
            MySQL
        }
    }
}
