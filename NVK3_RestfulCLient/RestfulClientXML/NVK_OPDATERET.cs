using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALRESTfulUtil.HttpClientXML;
using RestfulClientXML.Models.XML;
using RestfulClientXML.Util.XML;

namespace RestfulClientXML
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //XML
            //
            Util_XML_ConcertHall myConcertHallUtilXML = new Util_XML_ConcertHall("venueserviceaseece.azurewebsites.net", "", "venueservice");
            Util_XML_ConcertEquipment myConsertEquipmentUtilXML = new Util_XML_ConcertEquipment("venueserviceaseece.azurewebsites.net", "", "venueservice");

            ArrayOfConcertEquipment myXML_equipments = myConsertEquipmentUtilXML.GetConcertEquipments();


            //1. Opret 2 koncertsale
            ConcertHall xmlConcertHall1 = new ConcertHall()
            {
                ConcertHallId = 0000,
                ConcertHallName = "Voxhall",
                IsLocatatVenue = "Aarhus",
                HallResponsible = "Jonas Jensen",
                HallsizeM2 = 400,
                StagesizeM2 = 50,
                MaxNoAudience = 30,
                NoOfDoors = 5,
            };

            ConcertHall xmlConcertHall2 = new ConcertHall()
            {
                ConcertHallId = 0000,
                ConcertHallName = "Boxen",
                IsLocatatVenue = "Herning",
                HallResponsible = "Marie Jeppesen",
                HallsizeM2 = 10000,
                StagesizeM2 = 300,
                MaxNoAudience = 200,
                NoOfDoors = 20,
            };

            xmlConcertHall1 = myConcertHallUtilXML.PostConcertHall(xmlConcertHall1);
            xmlConcertHall2 = myConcertHallUtilXML.PostConcertHall(xmlConcertHall2);


            // 2. Opret og tilknyt 4 stykker udstyr til de to koncertsale
            ConcertHallConcertEquipment e = new ConcertHallConcertEquipment()
            {
                EquipmentId = 0,
                EquipmentName = "Gibson",
                Description = "Elektrisk guitar",
                FactoryName = "Gibson",
                EquipmentCount = 1100,
                BelongsToConcertHall = "Voxhall",
            };
            ConcertHallConcertEquipment f = new ConcertHallConcertEquipment()
            {
                EquipmentId = 0,
                EquipmentName = "Gibson",
                Description = "Akkustisk guitar",
                FactoryName = "Gibson",
                EquipmentCount = 1101,
                BelongsToConcertHall = "Voxhall",
            };

            ConcertHallConcertEquipment g = new ConcertHallConcertEquipment()
            {
                EquipmentId = 0,
                EquipmentName = "Yamaha",
                Description = "Keyboard",
                FactoryName = "Yamaha",
                EquipmentCount = 0001,
                BelongsToConcertHall = "Boxen",

            };

            ConcertEquipment h = new ConcertEquipment()
            {
                EquipmentId = 0,
                EquipmentName = "Yamaha",
                Description = "Trommer",
                FactoryName = "Yamaha",
                EquipmentCount = 0002,
                BelongsToConcertHall = "Bozen"

            };


            xmlConcertHall1.Equipment.Add(e);
            xmlConcertHall1.ConcertHallId = 0001;
           
            xmlConcertHall2.Equipment.Add(g);
            xmlConcertHall2.ConcertHallId = 0002;

            myConcertHallUtilXML.PutConcertHall(xmlConcertHall1);
            myConcertHallUtilXML.PutConcertHall(xmlConcertHall2);
         

            // 3. Slet et styk udstyr fra etn koncerthal
            myConsertEquipmentUtilXML.DeleteConcertEquipment(h);
            //200


            // Opgave 4: Ret et styk udstyr fra en koncerthal
            // Aktion PUT venueservice/ConcertEquipments /{id} 

            ConcertEquipment myEquipment = new ConcertEquipment() { EquipmentId = 20 };
            ConcertEquipment myEquipmentNEW = new ConcertEquipment() { EquipmentId = 15 };
            myEquipment = myConsertEquipmentUtilXML.GetConcertEquip(myEquipmentNEW);
            myEquipment.Description = "Epal-stol";
            myConsertEquipmentUtilXML.PostConcertEquipment(myEquipmentNEW);

            // Opgave 5: Slet en koncerthal og dens udstyr:
            //Aktion DELETE venueservice / ConcertHalls /{ id}

            ConcertHall myConcerthall = new ConcertHall() { ConcertHallId = 21 };
            ConcertHall myHall = myConcertHallUtilXML.DeleteConcertHall(myConcerthall);


            // Opgave 6: Vis en oversigt af udstyr for en koncertsal:
            // Aktion GET venueservice/ConcertHalls /{id} 

            ConcertHall myConcerthallTEST = new ConcertHall() { ConcertHallId = 19 };
            ConcertHall myHallTEST = myConcertHallUtilXML.GetConcertHall(myConcerthallTEST);

            // Opgave 7:  Vis en oversigt over alt udstyr uanset hvilken koncersal:
            //Aktion GET venueservice/ ConcertEquipments

            ArrayOfConcertEquipment HallsXML = myConsertEquipmentUtilXML.GetConcertEquipments();
            
        }
    }
}
