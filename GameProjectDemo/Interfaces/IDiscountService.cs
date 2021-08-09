using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Interfaces
{
    interface IDiscountService
    {
        void DiscountForGame(Game game);
        void FinalDateOfDiscount(Game game);

    }
}
