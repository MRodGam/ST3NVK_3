using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestfulClientXML.Models.XML;
using DALRESTfulUtil.HttpClientXML;

namespace RestfulClientXML.Util.XML
{
    class Util_XML_ConcertEquipment
    {
        private string portnumber, hostname, servicepath;
        private string fullservicepath;
        public Util_XML_ConcertEquipment(string hname, string portno, string serpath)
        {
            portnumber = portno;
            if (portno.Equals(""))
                hostname = "http://" + hname + "/";
            else hostname = "http://" + hname + ":" + portno + "/";
            servicepath = serpath + "/";
            fullservicepath = hostname + servicepath;
        }

        /*
         * ConcertEquipments metoder
         * https://venueserviceaseece.azurewebsites.net/venueservice/ConcertEquipments
         */

        public ArrayOfConcertEquipment GetConcertEquipments()
        {
            APIGetXML<ArrayOfConcertEquipment> ConcertEquipList = new APIGetXML<ArrayOfConcertEquipment>(this.fullservicepath + "ConcertEquipments");
            return ConcertEquipList.data;
        }

        public ConcertEquipment GetConcertEquip(ConcertEquipment concertEquip)
        {


            APIGetXML<ConcertEquipment> getConcertEquip = new APIGetXML<ConcertEquipment>(this.fullservicepath + "ConcertEquipments/" + concertEquip.EquipmentId);

            return getConcertEquip.data;
        }

        public ConcertEquipment PostConcertEquipment(ConcertEquipment postEpuip)
        {
            APIPostXML<ConcertEquipment> postConcertEquipment = new APIPostXML<ConcertEquipment>(hostname, servicepath, postEpuip);
            return postConcertEquipment.data;


        }

        public ConcertEquipment PutConcertEpuipment(ConcertEquipment putEquip)
        {
            APIPutXML<ConcertEquipment> putstConcerEpuiqment = new APIPutXML<ConcertEquipment>(hostname, servicepath + "ConcertEquipments/" + putEquip.EquipmentId, putEquip);
            return putstConcerEpuiqment.data;
        }


        public ConcertEquipment DeleteConcertEquipment(ConcertEquipment removeEpuip)
        {
            APIDeleteXML<ConcertEquipment> deleteConcertEquiqment = new APIDeleteXML<ConcertEquipment>(hostname, servicepath + "ConcertEquipments/" + removeEpuip.EquipmentId, removeEpuip);
            return deleteConcertEquiqment.data;
        }
    }
}
