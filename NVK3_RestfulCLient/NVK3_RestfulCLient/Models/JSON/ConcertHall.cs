using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVK3_RestfulCLient.Models.JSON
{
    class ConcertHall
    {
        public int ConcertHallId { get; set; }
        public string ConcertHallName { get; set; }
        public string IsLocatatVenue { get; set; }
        public string HallResponsible { get; set; }
        public float HallsizeM2 { get; set; }
        public float StagesizeM2 { get; set; }
        public int MaxNoAudience { get; set; }
        public int NoOfDoors { get; set; }
        public List<Equipment> Equipment { get; set; }

    }
}
