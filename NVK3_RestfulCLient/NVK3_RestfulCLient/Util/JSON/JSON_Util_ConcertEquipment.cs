using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NVK3_RestfulCLient.Models.JSON;
using DALRESTfulUtil.HttpClientJson;


namespace NVK3_RestfulCLient.Util.JSON
{
    class JSON_Util_ConcertEquipment
    {
        private string portnumber, hostname, servicepath;
        private string fullservicepath;
        public JSON_Util_ConcertEquipment(string hname, string portno, string serpath)
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

        public List<ConcertEquipment> GetConcertEquipments()
        {
            APIGetJSON<List<ConcertEquipment>> ConcertEquipList = new APIGetJSON<List<ConcertEquipment>>(this.fullservicepath + "ConcertEquipments");
            return ConcertEquipList.data;
        }

        public ConcertEquipment GetConcertEpuip(ConcertEquipment concertEpuip)
        {


            APIGetJSONAsync<ConcertEquipment> getConcertEquip = new APIGetJSONAsync<ConcertEquipment>(this.fullservicepath + "ConcertEquipments/" + concertEpuip.EquipmentId);

            return getConcertEquip.data;
        }

        public ConcertEquipment PostConcertEquipment(ConcertEquipment postEpuipment)
        {
            APIPostJSON<ConcertEquipment> postConcertEquipment = new APIPostJSON<ConcertEquipment>(hostname, servicepath, postEpuipment);
            return postConcertEquipment.data;


        }

        public ConcertEquipment PutConcertEpuipment(ConcertEquipment putEpuipment)
        {
            APIPutJSON<ConcertEquipment> putstConcerEpuiqment = new APIPutJSON<ConcertEquipment>(hostname, servicepath + "ConcertEquipments/" + putEpuipment.EquipmentId, putEpuipment);
            return putstConcerEpuiqment.data;
        }


        public ConcertEquipment DeleteConcertEquipment(ConcertEquipment removeEpuipment)
        {
            APIDeleteJSON<ConcertEquipment> deleteConcertEquiqment = new APIDeleteJSON<ConcertEquipment>(hostname, servicepath + "ConcertEquipments/" + removeEpuipment.EquipmentId, removeEpuipment);
            return deleteConcertEquiqment.data;
        }
    }
}
