using GameProjectDemo.Entities;
using GameProjectDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Managers
{
    class DiscountManager
    {
        public void Discount(Game game , IGamerService gamerService)
        {
            Console.WriteLine(gamerService.FirstName + " " + gamerService.LastName + " " + "adlı oyuncu" + " "
                + game.GameName + " " + "Adlı oyunu" + " " + game.GamePrice + " " + "Tl'ye satın aldı");
        }
        public void Add(Campaign campaign)
        {
            Console.Write("Tebrikler " + " " + campaign.CampaignName + " " + "adlı yeni kampanyamız sisteme eklendi ");
        }

        public void Update(Campaign campaign)
        {
            Console.Write("Tebrikler " + " " + campaign.CampaignName + " " + "adlı yeni kampanyamız sistemde güncellendi ");
        }

        public void Delete(Campaign campaign)
        {
            Console.Write("Tebrikler " + " " + campaign.CampaignName + " " + "adlı yeni kampanyamız sistemden silindi ");
        }
    }
}
