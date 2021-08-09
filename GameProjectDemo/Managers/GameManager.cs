using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Managers
{
    class GameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " " + "adlı oyun kütüphaneye eklenmiştir!");
        }
        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " " + "adlı oyun kütüphaneden silinmiştir!");
        }
        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " " + "adlı oyun güncellendi!");
        }
    }
}
