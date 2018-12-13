using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NVK3_RestfulCLient.Util.JSON;
using DALRESTfulUtil.HttpClientJson;
using NVK3_RestfulCLient.Models.JSON;

namespace NVK3_RestfulClient
{

    class Program
    {
        static void Main(string[] args)
        {
            VenueServiceUtilJSON testVenue = new VenueServiceUtilJSON("venueserviceaseece.azurewebsites.net","","venueservice");
            ConcertHall testConcertHall = new ConcertHall();
            Equipment testEquipment = new Equipment();

            testVenue.GetConcertHall();
            //testVenue.PostConcertHall(testConcertHall);
            //testVenue.DeleteConcertHall(testConcertHall);
            //testVenue.PutConcertHall(testConcertHall);
            //testVenue.PutEquipment(testEquipment);

            Console.ReadLine();
        }
    }

}
