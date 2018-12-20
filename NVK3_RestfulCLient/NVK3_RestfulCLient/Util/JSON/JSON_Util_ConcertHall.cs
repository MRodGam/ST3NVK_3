using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NVK3_RestfulCLient.Models.JSON;
using DALRESTfulUtil.HttpClientJson;

namespace NVK3_RestfulCLient.Util.JSON
{
    class JSON_Util_ConcertHall
    {
        private string portnumber, hostname, servicepath;
        private string fullservicepath;
        public JSON_Util_ConcertHall(string hname, string portno, string serpath)
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

        public List<ConcertHall> GetConcertHalls()
        {
            APIGetJSON<List<ConcertHall>> ConcertHallList = new APIGetJSON<List<ConcertHall>>(this.fullservicepath + "ConcertHalls");
            return ConcertHallList.data;
        }

        //Get 
        public ConcertHall GetConcertHall(ConcertHall getHall)
        {

            APIGetJSONAsync<ConcertHall> getConcertHall = new APIGetJSONAsync<ConcertHall>(this.fullservicepath + "ConcertHalls/" + getHall.ConcertHallId);
            return getConcertHall.data;
        }

        //Post
        public ConcertHall PostConcertHall(ConcertHall post)
        {
            APIPostJSON<ConcertHall> postConcertHall = new APIPostJSON<ConcertHall>(hostname, servicepath, post);
            return postConcertHall.data;


        }
        //Put
        public ConcertHall PutConcertHall(ConcertHall put)
        {
            APIPutJSON<ConcertHall> putConcertHall = new APIPutJSON<ConcertHall>(hostname, servicepath, put);
            return putConcertHall.data;
        }

        //Delete
        public ConcertHall DeleteConcertHall(ConcertHall remove)
        {
            APIDeleteJSON<ConcertHall> deleteConcertHall = new APIDeleteJSON<ConcertHall>(hostname, servicepath, remove);
            return deleteConcertHall.data;
        }
    }
}
