
namespace ExConPram.DataBase
{
    /// <summary>
    /// Пример класса 
    /// </summary>
    public class GoodsClass : ClassDBParam
    {
        [SqlReq()]
        public StatusEnum Status { get; set; } = StatusEnum.Продаеться;
        [SqlReq(0, 50)]
        public string Сountry { get; set; }
        [SqlReq(1,8)]
        public decimal Price { get; set; }
        [SqlReq(1,3)]
        public decimal MarkupSng { get; set; }
        [SqlReq()]
        public string Comment { get; set; }

        [SqlReqObj]
        public GrupClass Grup { get; set; }
        [SqlReqObj]
        public CarBrandClass MachineBrand { get; set; }
        [SqlReqObj]
        public ModificationClass Modification { get; set; }

        public class GrupClass : ClassDBParam
        {
            [SqlReq()]
            public string TypeCar { get; set; }           
            [SqlReq()]
            public System.Drawing.Color ColorField { get; set; } = System.Drawing.Color.White ;           
        }
       
        public enum StatusEnum
        {
            Продано,
            Продаеться,
            Резерв
        }

        public class CarBrandClass : ClassDBParam
        {
            [SqlReq(1, 60)]
            public string NameBrand { get; set; }
            [SqlReq(1, 10)]
            public long Serial { get; set; }
            [SqlReq(4, 4)]
            public short GenerationYear { get; set; } = 0;
        }

        public class ModificationClass : ClassDBParam
        {
            [SqlReq(0, 40)]
            public string TypeEngine { get; set; }
            [SqlReq()]
            public bool AirConditioner { get; set; }
            [SqlReq()]
            public bool DiscBrakes { get; set; }
            [SqlReq()]
            public bool AutoMusic { get; set; }
            [SqlReq()]
            public bool Rugs { get; set; }
        }
    }
}
