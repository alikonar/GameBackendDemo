using GameBackendDemo.Entites;
using GameBackendDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendDemo.Managers
{
    public class GameManager : IGameService
    {
        public void BonusMoney(Customer customer, Game game)
        {
            Console.WriteLine(customer.NickName+">>"+game.GameName+" oyunu satın alarak 10 bonus money kazandı");
        }

        public void BuyGame(Customer customer,Game game)
        {
            Console.WriteLine("--------");
            Console.WriteLine(customer.NickName + "- İsimli kullanıcı " + game.GameName + " isimli oyunu satın aldı.");
        }

        public void RebateGame(Game game,Customer customer)
        {
            Console.WriteLine("---------");
            Console.WriteLine(customer.NickName+" isimli kullanıcı şu işlemi yaptı.");
            Console.WriteLine("Oyun iade edildi.");
            Console.WriteLine("Game Id: "+game.GameId);
            Console.WriteLine("Game: "+game.GameName);
            Console.WriteLine("İade edilen tutar: "+game.GamePrice);
        }
    }
}
