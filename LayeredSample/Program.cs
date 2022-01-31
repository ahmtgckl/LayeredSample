using LayeredSample.Abstract;
using LayeredSample.Concrete;
using LayeredSample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oyunların oluşturulduğu kısım 
            Game game1 = new Game
            {
                GameName = "Call Of Duty",
                GameCategory = "Savaş",
                GamePrice = 80
            };
            Game game2 = new Game
            {
                GameName = "Uncharted 4",
                GameCategory = "Macera",
                GamePrice = 100
            };
            Game game3 = new Game
            {
                GameName = "God Of War",
                GameCategory = "Aksiyon, Dövüş",
                GamePrice = 45
            };

            //Kampanyaların Oluşturulduğ Kısım 
            Campaigns campaign1 = new Campaigns();
            campaign1.CampaignName = "Yaz İndirimi";
            campaign1.CampaignDiscount = 65;

            Campaigns campaign2 = new Campaigns();
            campaign2.CampaignName = "Haftasonu İndirimi";
            campaign2.CampaignDiscount = 15;


            //Müşterilerin oluşturuluğu kısım
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Ahmet";
            customer1.LastName = "GÜÇKOL";
            customer1.NationalityId = "12345678987";
            customer1.DateOfBirth = new DateTime(1989, 02, 27);



            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Ceylin";
            customer2.LastName = "HÜR";
            customer2.NationalityId = "56412369874";
            customer2.DateOfBirth = new DateTime(1989, 06, 12);


            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Alparslan";
            customer3.LastName = "KISMET";
            customer3.NationalityId = "98765432132";
            customer3.DateOfBirth = new DateTime(1988, 10, 18);

            //Müşterilerin yönetildiği kısım (Add, Update, Delete)
            CustomerManager customerManager = new CustomerManager(new VerificationManager());
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Update(customer1);
            customerManager.Delete(customer3);

            Console.WriteLine("************************");

            //Oyunların yönetildiği kısım 
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            Console.WriteLine("      -----        ");
            gameManager.Update(game2);
           


            Console.WriteLine("************************");

            //Kampanyaların yönetildiği kısım 
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign2);

            Console.WriteLine("************************");

            //Oyun satışlarının yönetildiği kısım. 
            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(customer1, game1, campaign1);

            Console.WriteLine("************************");

            gameSaleManager.Sale(customer2, game3, campaign2);


            Console.ReadLine();
        }
    }
}
