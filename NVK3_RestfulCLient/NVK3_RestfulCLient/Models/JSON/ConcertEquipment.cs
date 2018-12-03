using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVK3_RestfulCLient.Models.JSON
{
    class ConcertEquipment
    {
        public int EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public string Description { get; set; }
        public string FactoryName { get; set; }
        public int EquipmentCount { get; set; }
        public string BelongsToConcertHall { get; set; }
    }
}
