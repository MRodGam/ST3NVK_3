using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NVK3_RestfulCLient.Models.JSON;
using DALRESTfulUtil.HttpClientJson;

namespace NVK3_RestfulCLient.Util.JSON
{
    class VenueServiceUtilJSON
    {
        private string portnumber, hostname, servicepath;
        private string fullservicepath;

        public VenueServiceUtilJSON(string hname, string portno, string serpath)
        {
            portnumber = portno;
            if (portno.Equals(""))
                hostname = "http://" + hname + "/";
            else hostname = "http://" + hname + ":" + portno + "/";
            servicepath = serpath + "/";
            fullservicepath = hostname + servicepath;
        }

        public List<ConcertHall> GetConcertHall()
        {
            APIGetJSON<List<ConcertHall>> getconcerthall = new APIGetJSON<List<ConcertHall>>(this.fullservicepath + "ConcertHalls");
            return getconcerthall.data;
        }

        public ConcertHall PostConcertHall(ConcertHall postedHall)
        {
            APIPostJSON<ConcertHall> postconcerthall = new APIPostJSON<ConcertHall>(this.hostname, this.servicepath + "ConcertHalls", postedHall);
            return postconcerthall.data;
        }

        public ConcertHall DeleteConcertHall(ConcertHall deletedHall)
        {
            APIDeleteJSON<ConcertHall> deleteconcerthall = new APIDeleteJSON<ConcertHall>(this.hostname, this.servicepath + "ConcetHalls", deletedHall);
            return deleteconcerthall.data;
        }

        public ConcertHall PutConcertHall(ConcertHall placedConcertHall)
        {
            APIPutJSON<ConcertHall> putconcerthall = new APIPutJSON<ConcertHall>(this.hostname, this.servicepath + "ConcertHalls", placedConcertHall);
            return putconcerthall.data;
        }

        public Equipment PutEquipment(Equipment placedEquipment)
        {
            APIPutJSON<Equipment> putequiment = new APIPutJSON<Equipment>(this.hostname, this.servicepath + "ConcertEquipment", placedEquipment);
            return putequiment.data;
        }

        public Equipment DeleteEquipment(Equipment deletedEquipment)
        {
            APIDeleteJSON<Equipment> deleteequipment = new APIDeleteJSON<Equipment>(this.hostname, this.servicepath + "ConcertEquipment", deletedEquipment);
            return deleteequipment.data;
        }

        public Event GetEvent()
        {
            APIGetJSON<Event> getevent = new APIGetJSON<Event>(this.fullservicepath + "Events");
            return getevent.data;
        }
    }
}


