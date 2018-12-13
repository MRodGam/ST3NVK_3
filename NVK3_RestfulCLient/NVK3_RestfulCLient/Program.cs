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
            List<Equipment> testEquipment= new List<Equipment>();
            ConcertHall testConcertHall = new ConcertHall(0000,"Voxhall","Aarhus","Jonas Jensen", 400,50,300,5,testEquipment);

            testConcertHall = testVenue.PostConcertHall(testConcertHall);
            List<ConcertHall> testList = testVenue.GetConcertHall();

            //testVenue.PostConcertHall(testConcertHall);
            //testVenue.DeleteConcertHall(testConcertHall);
            //testVenue.PutConcertHall(testConcertHall);
            //testVenue.PutEquipment(testEquipment);

            Console.ReadLine();
        }
    }

}
