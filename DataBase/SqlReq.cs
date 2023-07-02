
namespace ExConPram.DataBase
{
    // Необходим для того чтобы пометить какие данные сохранять в БД

    /// <summary>
    /// Сборка кастомных CustomAttributes
    /// </summary>
    public interface ISqlField {
        /// <summary>
        /// Кастомное значение Datatypes, не будет запрашиваться через TypeSQL, необходин для создания сложный и спец. Datatypes BD 
        /// </summary>
        public string Type_Param { get;  }
        /// <summary>
        /// Дополнительные параметры, расширяющие
        /// </summary>
        public string Parametor { get; }     
    }


    /// <summary>
    /// Для элементов базы данных должен быть Property, другите игронируеться
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Property)]
    public class SqlReq : System.Attribute, ISqlField
    {
        /// <summary>
        /// Тип данных указанный вручную, он будет преобразован через <b>ISQLCommander.TypeSQL</b>
        /// </summary>
        public string Type_Param { get;  }
        /// <summary>
        /// Тут параметры для типа указывать () обзазательно если требует синтаксис
        /// </summary>
        public string Parametor { get;  }

        public int MaxValue = -1;
        public int MinValue = -1;

        public SqlReq(string typeParam = "", string parametor = "")
        {                   
            Parametor = parametor;
            Type_Param = typeParam;
        }

        public SqlReq(int minValue, string typeParam = "", string parametor = "")
        {
            MinValue = minValue; 
            Parametor = parametor;
            Type_Param = typeParam;
        }
        public SqlReq(int minValue, int maxValue, string typeParam = "", string parametor = "")
        {
            MinValue = minValue;
            MaxValue = maxValue;
            Parametor = parametor;
            Type_Param = typeParam;
        }
    }


    /// <summary>
    /// Для класа или структуры он должен быть Property, другите игронируеться
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Property)]
    public class SqlReqObj : System.Attribute, ISqlField
    {     
        public string Type_Param { get => "INTEGER"; }
        public string Parametor { get => ""; }
    }
}
