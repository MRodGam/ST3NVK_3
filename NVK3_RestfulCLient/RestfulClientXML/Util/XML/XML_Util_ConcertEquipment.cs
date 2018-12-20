using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestfulClientXML.Models.XML;
using DALRESTfulUtil.HttpClientXML;

namespace RestfulClientXML.Util.XML
{
    public class XML_Util_ConcertEquipment
    {
        private string portnumber, hostname, servicepath;
        private string fullservicepath;

        public XML_Util_ConcertEquipment(string hname, string portno, string serpath)
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
            APIGetXML <ArrayOfConcertEquipment> ConcertEquipList = new APIGetXML <ArrayOfConcertEquipment> (this.fullservicepath + "ConcertEquipments");
            return ConcertEquipList.data;
        }

        public ConcertEquipment GetConcertEquip(ConcertEquipment concertEquip)
        {
            APIGetXML<ConcertEquipment> getConcertEquip = new APIGetXML<ConcertEquipment>(this.fullservicepath + "ConcertEquipments/" + concertEquip.EquipmentId);

            return getConcertEquip.data;
        }

        public ConcertEquipment PostConcertEpuipment(ConcertEquipment putEquip)
        {
            APIPostXML<ConcertEquipment> postConcerEpuiqment = new APIPostXML<ConcertEquipment>(hostname, servicepath + "ConcertEquipments/" + putEquip.EquipmentId,putEquip);
            return postConcerEpuiqment.data;
        }
        public ConcertEquipment PutConcertEpuipment(ConcertEquipment putEquip)
        {
            APIPutXML<ConcertEquipment> putConcerEpuiqment = new APIPutXML<ConcertEquipment>(hostname, servicepath + "ConcertEquipments/" + putEquip.EquipmentId, putEquip);
            return putConcerEpuiqment.data;
        }



        public ConcertEquipment DeleteConcertEquipment(ConcertEquipment removeEpuip)
        {
            APIDeleteXML<ConcertEquipment> deleteConcertEquiqment = new APIDeleteXML<ConcertEquipment>(hostname, servicepath + "ConcertEquipments/" + removeEpuip.EquipmentId, removeEpuip);
            return deleteConcertEquiqment.data;
        }


    }
}
