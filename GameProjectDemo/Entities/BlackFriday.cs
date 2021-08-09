using GameProjectDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Entities
{
    class BlackFriday : IDiscountService
    {
        double discountPrice;
        public void DiscountForGame(Game game)
        {
            discountPrice = (game.GamePrice * (0.75));
            game.GamePrice = (int)(game.GamePrice - discountPrice);
            Console.WriteLine("Tebrikler ürününüze yaz indirimi uygulandı" + " " + game.GameName + " " 
                + "Adlı oyunun indirimli fiyatı " + "=" + " " + game.GamePrice + " " + "TL");
        }

        public void FinalDateOfDiscount(Game game)
        {
            game.GamePrice = (int)(game.GamePrice - discountPrice);
            Console.WriteLine("Üzgünüz , Black Friday indirimleri sona erdi!");

        }

    }
}
