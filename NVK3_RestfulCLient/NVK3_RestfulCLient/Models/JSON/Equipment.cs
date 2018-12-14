using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVK3_RestfulCLient.Models.JSON
{
    class Equipment
    {
        public int EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public string Description { get; set; }
        public string FactoryName { get; set; }
        public int EquipmentCount { get; set; }
        public string BelongsToConcertHall { get; set; }

        public Equipment(int id, string name, string description, string factory, int equipmentnr, string belongsto)
        {
            EquipmentId = id;
            EquipmentName = name;
            Description = description;
            FactoryName = factory;
            EquipmentCount = equipmentnr;
            BelongsToConcertHall = belongsto;
        }
    }
}
