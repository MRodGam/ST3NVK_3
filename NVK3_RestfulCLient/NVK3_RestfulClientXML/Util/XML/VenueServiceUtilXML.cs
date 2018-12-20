using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NVK3_RestfulCLient.Models.XML;
using DALRESTfulUtil.HttpClientXML;

namespace NVK3_RestfulCLient.Util.XML
{
    class VenueServiceUtilXML
    {
        private string portnumber, hostname, servicepath;
        private string fullservicepath;

        public VenueServiceUtilXML(string hname, string portno, string serpath)
        {
            portnumber = portno;
            if (portno.Equals(""))
                hostname = "http://" + hname + "/";
            else hostname = "http://" + hname + ":" + portno + "/";
            servicepath = serpath + "/";
            fullservicepath = hostname + servicepath;
        }

        public List<ConcertHall> GetConcertHallXML()
        {
            APIGetXML<List<ConcertHall>> getconcerthall = new APIGetXML<List<ConcertHall(this.fullservicepath + "ConcertHalls")>>;
            return getconcerthall.data;
        }

        public ConcertHall GetSingleConcertHallXML(ConcertHall getHall)
        {
            APIPostXML<ConcertHall> getsingleconcerthall = new APIPostXML<ConcertHall>(this.hostname, this.servicepath + "ConcertHalls/" + getHall.ConcertHallId, getHall);
            return getsingleconcerthall.data;
        }

        public ConcertHall PostConcertHallXML(ConcertHall postedHall) // Den her giver fejl
        {
            APIPostXML<ConcertHall> postconcerthall = new APIPostXML<ConcertHall>(this.hostname, this.servicepath + "ConcertHalls/" + postedHall.ConcertHallId, postedHall);
            return postconcerthall.data;
        }

        public ConcertHall DeleteConcertHallXML(ConcertHall deletedHall)
        {
            APIDeleteXML<ConcertHall> deleteconcerthall = new APIDeleteXML<ConcertHall>(this.hostname, this.servicepath + "ConcertHalls/" + deletedHall.ConcertHallId, deletedHall);
            return deleteconcerthall.data;
        }

        public ConcertHall PutConcertHallXML(ConcertHall placedConcertHall)
        {
            APIPutXML<ConcertHall> putconcerthall = new APIPutXML<ConcertHall>(this.hostname, this.servicepath + "ConcertHalls/" + placedConcertHall.ConcertHallId, placedConcertHall);
            return putconcerthall.data;
        }

        public List<Equipment> GetEquipmentXML()
        {
            APIGetXML<List<Equipment>> getequiment = new APIGetXML<List<Equipment>>(this.fullservicepath + "ConcertEquipments");
            return getequiment.data;
        }

        public Equipment PutEquipmentXML(Equipment placedEquipment)
        {
            APIPutXML<Equipment> putequiment = new APIPutXML<Equipment>(this.hostname, this.servicepath + "ConcertEquipments/" + placedEquipment.EquipmentId, placedEquipment);
            return putequiment.data;
        }

        public Equipment DeleteEquipmentXML(Equipment deletedEquipment)
        {
            APIDeleteXML<Equipment> deleteequipment = new APIDeleteXML<Equipment>(this.hostname, this.servicepath + "ConcertEquipments/" + deletedEquipment.EquipmentId, deletedEquipment);
            return deleteequipment.data;
        }
    }
}
