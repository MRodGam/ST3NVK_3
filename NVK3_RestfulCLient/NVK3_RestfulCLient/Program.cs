using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NVK3_RestfulCLient.Util.JSON;
using DALRESTfulUtil.HttpClientJson;
using NVK3_RestfulCLient.Models.JSON;         // Indkommentér til JSON Test

namespace NVK3_RestfulClient
{

    class Program
    {
        static void Main(string[] args)
        {
            //
            //JSON
            //
            VenueServiceUtilJSON testVenue = new VenueServiceUtilJSON("venueserviceaseece.azurewebsites.net","","venueservice");
           

            //1. Opret 2 koncertsale
            List<Equipment> testEquipment1 = new List<Equipment>();
            ConcertHall testConcertHall1 = new ConcertHall(0000, "Voxhall", "Aarhus", "Jonas Jensen", 400, 50, 300, 5, testEquipment1);
          

            List<Equipment> testEquipment2 = new List<Equipment>();
            ConcertHall testConcertHall2 = new ConcertHall(0001, "Boxen","Herning", "Marie Jeppesen", 3000,100,10000,20,testEquipment2);


            testConcertHall1 = testVenue.PostConcertHall(testConcertHall1);
            List<ConcertHall> testList1 = testVenue.GetConcertHall();
            //201

            testConcertHall2 = testVenue.PostConcertHall(testConcertHall2);
            List<ConcertHall> testList2 = testVenue.GetConcertHall();
            //201

            // 2. Opret og tilknyt 4 stykker udstyr til de to koncertsale
            List<Equipment> testEquipment3 = new List<Equipment>();
            ConcertHall testConcertHall3 = new ConcertHall(0303, "O2 Arena", "Berlin", "Jane Wilson", 5000, 300, 20000, 50, testEquipment3);
            testConcertHall3.ConcertHallId = 0303;

            Equipment a = new Equipment(0, "Gibson", "Elektrisk guitar", "Gibson", 1000, "O2 Arena"); 
            Equipment b = new Equipment(0, "Gibson", "Elektrisk guitar", "Gibson", 1100, "O2 Arena");
            testConcertHall3.Equipment.Add(a);
            testConcertHall3.Equipment.Add(b);

            testVenue.PutConcertHall(testConcertHall3);
            //201

            List<Equipment> testEquipment4 = new List<Equipment>();
            ConcertHall testConcertHall4 = new ConcertHall(0091, "Bodegaen", "Bramming", "Ida Martinsen", 87, 0, 100, 3, testEquipment4);
            testConcertHall4.ConcertHallId = 0091;

            Equipment c = new Equipment(0, "Fender", "Akkustisk guitar", "Fender", 0001, "Bodegaen");
            Equipment d = new Equipment(0, "Yamaha", "Keyboard", "Yamaha", 0500, "Bodegaen");
            testConcertHall4.Equipment.Add(c);
            testConcertHall4.Equipment.Add(d);

            testVenue.PutConcertHall(testConcertHall4);
            //201



            // 3. Slet et styk udstyr fra etn koncerthal
            a.EquipmentId = 200;
            testVenue.DeleteEquipment(a);
            //200

            b.EquipmentId = 300;
            testVenue.DeleteEquipment(b);
            //200


            //4. Ret et styk udfstyr fra en koncerthal
            c.EquipmentId = 500;
            c.EquipmentName = "Tamborin";
            testVenue.PutEquipment(c);

            //204

            //5. Slet en koncerthal og dens udstyr
            testVenue.DeleteConcertHall(testConcertHall1);
            //200

            //6. Vis en oversift af udstyr for en koncertsal
            testConcertHall1.ConcertHallId = 0000;
            testVenue.GetSingleConcertHall(testConcertHall1);
            //202

            //7. Vis en oversigt over alt udstyr uanset hvilken konertskr
            testVenue.GetEquipment();
            //200
        }
    }

}
