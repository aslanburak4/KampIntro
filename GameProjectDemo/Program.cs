using GameProjectDemo.Entities;
using GameProjectDemo.Managers;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.IdentityNumber = 12345678901;
            gamer1.FirstName = "Berkin";
            gamer1.LastName = "Topaloğlu";
            gamer1.BirthYear = "28/03/2000";

            Gamer gamer2 = new Gamer();
            gamer2.IdentityNumber = 12345678902;
            gamer2.FirstName = "Burak";
            gamer2.LastName = "Aslan";
            gamer2.BirthYear = "04/02/2000";

            Gamer gamer3 = new Gamer();
            gamer3.IdentityNumber = 12345678903;
            gamer3.FirstName = "Logar";
            gamer3.LastName = "Komutan";
            gamer3.BirthYear = "01/01/1967";


            Game game = new Game();
            game.GameId = 01;
            game.GameName = "ENGIN HOCA ILE MACERALAR";
            game.GamePrice = 27.99;
            game.GameCategory = "Adventure";


            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(new Gamer { FirstName = "Alican", LastName = "Dayi", IdentityNumber = 12345678904, BirthYear = "2000" });
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);

            GameManager gameManager = new GameManager();
            gameManager.Add(new Game { GameId = 01, GameName = "ENGIN HOCA ILE MACERALAR", GamePrice = 27.99 });
            gameManager.Update(game);
            gameManager.Delete(game);
        }
    }
}
