using GameProjectDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Managers
{
    class GamerManager
    {
        public void Add(IGamerService gamerService)
        {
            Console.WriteLine(gamerService.FirstName + " " + gamerService.LastName + " " + "isimli oyuncu sisteme eklendi");
        }
        public void Delete(IGamerService gamerService)
        {
            Console.WriteLine(gamerService.FirstName + " " + gamerService.LastName + " " + "isimli oyuncu sistemden silindi");
        }
        public void Update(IGamerService gamerService)
        {
            Console.WriteLine(gamerService.FirstName + " " + gamerService.LastName + " " + "isimli oyuncu sistemde güncellendi");
        }
    }
}
