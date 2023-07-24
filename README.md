Сохраняет данный из класса в БД, с учетом оптимизации и совместимостью с БД.
1.	Класс который нужно сохранять в БД должен быть унаследован от ClassDBParam
Пример public class GoodsClass : ClassDBParam
2.	Те поля которые должны быть учтены при сохранении должны быть помечены как [SqlReq("тут тип данных", "тут необязательный параметр ")]
Пример [SqlReq("string", "(10)")] string – десять символов при создание будет так НазваниеПеременной VARCHAR (10)
Можно не указывать тип данных будет основана на основе переменной, способ выше это принудительный.
[SqlReq(0, 50)] это пример создаст на основе типа данных переменной которая может содержать от 0-50 символов не более
[SqlReq()] либо ничего не указывать 
 [SqlReq("string", "(10)")]
        public StatusEnum Status { get; set; } 
        [SqlReq(0, 50)]
        public string Сountry { get; set; }
        [SqlReq(1,8)]
        public decimal Price { get; set; }
        [SqlReq(1,3)]
        public decimal MarkupSng { get; set; }
        [SqlReq("string", "(200)")]
  public string Comment { get; set; }

3.	Теперь необходимо подключить БД ISQLCommander содержит несколько типов подключения MsSql, Sqlite, MySql эти классы реализуют  ISQLCommander
4.	ISQLCommander SQLCommander; SQLCommander.Connect(); Выполняет подключение, важно учитывать property для настроек подключения
5.	Создает таблиц если их нет  CreateTabel проверяет на существование SQLCommander.CreateTabel<DataBase.GoodsClass>(), также к вложенным классам 
6.	WorkForm – помогает сохранить данный из формы прямо в класс. Или получить их БД как класс. Проверяет данные на соответствие. 
7.	Можно без WorkForm обновить класс в БД с помощи  GoodsClass.Update(SQLCommander); где GoodsClass это ваш класс, данные вы заполняете другим способом. Или получить данный из БД по ид GoodsClass. GetDate (5, SQLCommander);      

