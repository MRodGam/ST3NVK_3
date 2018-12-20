using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestfulClientXML.Models.XML;
using DALRESTfulUtil.HttpClientXML;

namespace RestfulClientXML.Util.XML
{
    class Util_XML_ConcertHall
    {
        private string portnumber, hostname, servicepath;
        private string fullservicepath;

        public Util_XML_ConcertHall(string hname, string portno, string serpath)
        {
            portnumber = portno;
            if (portno.Equals(""))
                hostname = "http://" + hname + "/";
            else hostname = "http://" + hname + ":" + portno + "/";
            servicepath = serpath + "/";
            fullservicepath = hostname + servicepath;
        }

        /*
         * ConcertHalls metoder
         * http://venueserviceaseece.azurewebsites.net/venueservice/ConcertHalls
         */

        public List<ArrayOfConcertHall> GetConcertHalls()
        {
            APIGetXML<List<ArrayOfConcertHall>> ConcertHallList = new APIGetXML<List<ArrayOfConcertHall>>(this.fullservicepath + "ConcertHalls");
            return ConcertHallList.data;
        }

        //Get 
        public ConcertHall GetConcertHall(ConcertHall getHall)
        {

            APIGetXML<ConcertHall> getConcertHall = new APIGetXML<ConcertHall>(this.fullservicepath + "ConcertHalls/" + getHall.ConcertHallId);
            return getConcertHall.data;
        }

        //Post
        public ConcertHall PostConcertHall(ConcertHall post)
        {
            APIPostXML<ConcertHall> postConcertHall = new APIPostXML<ConcertHall>(hostname, servicepath, post);
            return postConcertHall.data;


        }
        //Put
        public ConcertHall PutConcertHall(ConcertHall put)
        {
            APIPutXML<ConcertHall> putConcertHall = new APIPutXML<ConcertHall>(hostname, servicepath, put);
            return putConcertHall.data;
        }

        //Delete
        public ConcertHall DeleteConcertHall(ConcertHall remove)
        {
            APIDeleteXML<ConcertHall> deleteConcertHall = new APIDeleteXML<ConcertHall>(hostname, servicepath, remove);
            return deleteConcertHall.data;
        }
    }
}
