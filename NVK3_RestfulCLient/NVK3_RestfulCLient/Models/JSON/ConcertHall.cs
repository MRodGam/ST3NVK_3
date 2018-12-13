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

        public ConcertHall(int ID, string name, string location, string hallresp, float hallsize, float stagesize, int audience, int doors, List<Equipment> equipment)
        {
            ConcertHallId = ID;
            ConcertHallName = name;
            IsLocatatVenue = location;
            HallResponsible = hallresp;
            HallsizeM2 = hallsize;
            StagesizeM2 = stagesize;
            MaxNoAudience = audience;
            NoOfDoors = doors;
            Equipment = equipment;
        }

    }

}
