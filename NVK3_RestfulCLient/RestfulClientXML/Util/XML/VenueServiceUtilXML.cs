//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using RestfulClientXML.Models.XML;
//using DALRESTfulUtil.HttpClientXML;

//namespace RestfulClientXML.Util.XML
//{
//    public class VenueServiceUtilXML
//    {
//        private string portnumber, hostname, servicepath;
//        private string fullservicepath;

//        public VenueServiceUtilXML(string hname, string portno, string serpath)
//        {
//            portnumber = portno;
//            if (portno.Equals(""))
//                hostname = "http://" + hname + "/";
//            else hostname = "http://" + hname + ":" + portno + "/";
//            servicepath = serpath + "/";
//            fullservicepath = hostname + servicepath;
//        }

//        /*
//         * ConcertHalls metoder
//         * http://venueserviceaseece.azurewebsites.net/venueservice/ConcertHalls
//         */

//        public List<ArrayOfConcertHall> GetConcertHalls()
//        {
//            APIGetXML<List<ArrayOfConcertHall>> ConcertHallList = new APIGetXML<List<ArrayOfConcertHall>>(this.fullservicepath + "ConcertHalls");
//            return ConcertHallList.data;
//        }

//        //Get 
//        public ConcertHall GetConcertHall(ConcertHall getHall)
//        {

//            APIGetXML<ConcertHall> getConcertHall = new APIGetXML<ConcertHall>(this.fullservicepath + "ConcertHalls/" + getHall.ConcertHallId);
//            return getConcertHall.data;
//        }

//        //Post
//        public ConcertHall PostConcertHall(ConcertHall post)
//        {
//            APIPostXML<ConcertHall> postConcertHall = new APIPostXML<ConcertHall>(hostname, servicepath, post);
//            return postConcertHall.data;


//        }
//        //Put
//        public ConcertHall PutConcertHall(ConcertHall put)
//        {
//            APIPutXML<ConcertHall> putConcertHall = new APIPutXML<ConcertHall>(hostname, servicepath, put);
//            return putConcertHall.data;
//        }

//        //Delete
//        public ConcertHall DeleteConcertHall(ConcertHall remove)
//        {
//            APIDeleteXML<ConcertHall> deleteConcertHall = new APIDeleteXML<ConcertHall>(hostname, servicepath, remove);
//            return deleteConcertHall.data;
//        }


//        /*
//         * ConcertEquipments metoder
//         * https://venueserviceaseece.azurewebsites.net/venueservice/ConcertEquipments
//         */

//        public ArrayOfConcertEquipment GetConcertEquipments()
//        {
//            APIGetXML <ArrayOfConcertEquipment> ConcertEquipList = new APIGetXML <ArrayOfConcertEquipment> (this.fullservicepath + "ConcertEquipments");
//            return ConcertEquipList.data;
//        }

//        public ConcertEquipment GetConcertEquip(ConcertEquipment concertEquip)
//        {
//            APIGetXML<ConcertEquipment> getConcertEquip = new APIGetXML<ConcertEquipment>(this.fullservicepath + "ConcertEquipments/" + concertEquip.EquipmentId);

//            return getConcertEquip.data;
//        }

//        public ConcertEquipment PostConcertEpuipment(ConcertEquipment putEquip)
//        {
//            APIPostXML<ConcertEquipment> postConcerEpuiqment = new APIPostXML<ConcertEquipment>(hostname, servicepath + "ConcertEquipments/" + putEquip.EquipmentId,putEquip);
//            return postConcerEpuiqment.data;
//        }
//        public ConcertEquipment PutConcertEpuipment(ConcertEquipment putEquip)
//        {
//            APIPutXML<ConcertEquipment> putConcerEpuiqment = new APIPutXML<ConcertEquipment>(hostname, servicepath + "ConcertEquipments/" + putEquip.EquipmentId, putEquip);
//            return putConcerEpuiqment.data;
//        }



//        public ConcertEquipment DeleteConcertEquipment(ConcertEquipment removeEpuip)
//        {
//            APIDeleteXML<ConcertEquipment> deleteConcertEquiqment = new APIDeleteXML<ConcertEquipment>(hostname, servicepath + "ConcertEquipments/" + removeEpuip.EquipmentId, removeEpuip);
//            return deleteConcertEquiqment.data;
//        }


//        public List<ArrayOfConcertHall> GetConcertHalls()
//        {
//            APIGetXML<List<ArrayOfConcertHall>> ConcertHallList = new APIGetXML<List<ArrayOfConcertHall>>(this.fullservicepath + "ConcertHalls");
//            return ConcertHallList.data;
//        }

//        public ConcertHall GetConcertHall(ConcertHall getHall)
//        {

//            APIGetXML<ConcertHall> getConcertHall = new APIGetXML<ConcertHall>(this.fullservicepath + "ConcertHalls/" + getHall.ConcertHallId);
//            return getConcertHall.data;
//        }
        
//        public ConcertHall PostConcertHall(ConcertHall put)
//        {
//            APIPostXML<ConcertHall> postConcertHall = new APIPostXML<ConcertHall>(hostname, servicepath, put);
//            return postConcertHall.data;
//        }

//        public ConcertHall PutConcertHall(ConcertHall put)
//        {
//            APIPutXML<ConcertHall> putConcertHall = new APIPutXML<ConcertHall>(hostname, servicepath, put);
//            return putConcertHall.data;
//        }

//        public ConcertHall DeleteConcertHall(ConcertHall remove)
//        {
//            APIDeleteXML<ConcertHall> deleteConcertHall = new APIDeleteXML<ConcertHall>(hostname, servicepath, remove);
//            return deleteConcertHall.data;
//        }
//    }
//}
