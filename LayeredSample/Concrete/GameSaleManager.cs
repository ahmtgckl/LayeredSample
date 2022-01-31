using LayeredSample.Abstract;
using LayeredSample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredSample.Concrete
{
    internal class GameSaleManager : IGameSaleService
    {
        public void Sale(Customer customer, Game game, Campaigns campaign)
        {
            double newPrice = game.GamePrice - (game.GamePrice * (campaign.CampaignDiscount / 100));
            Console.WriteLine(game.GameName + " oyunu " + customer.FirstName + " " + customer.LastName + " kişisine satıldı.");
            Console.WriteLine("Oyunun indirimli Fiyatı : " + newPrice + " $");
            Console.WriteLine("Uygulanan İndirim fiyatı : " + game.GamePrice * (campaign.CampaignDiscount / 100) + " $");

        }
    }
}
