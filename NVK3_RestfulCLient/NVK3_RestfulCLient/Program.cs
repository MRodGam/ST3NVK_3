using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NVK3_RestfulCLient.Util.JSON;
using DALRESTfulUtil.HttpClientJson;

namespace NVK3_RestfulClient
{

    class Program
    {
        static void Main(string[] args)
        {
            VenueServiceUtilJSON testVenue = new VenueServiceUtilJSON("venueserviceaseece.azurewebsites.net","","venueservice");

            testVenue.GetConcertHall();
            testVenue.PostConcertHall();
            testVenue.DeleteEquipment();

            Console.ReadLine();
        }
    }

}
