using GameBackendDemo.Entites;
using GameBackendDemo.Managers;
using System;
using System.Collections.Generic;

namespace GameBackendDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Games
            Game game1 = new Game();
            game1.GameId = 101;
            game1.GameCategoryId = 1;
            game1.GameName = "BF5";
            game1.GamePrice = "19 Dollar";

            Game game2 = new Game();
            game2.GameId = 188;
            game2.GameCategoryId = 2;
            game2.GameName = "COD4";
            game2.GamePrice = "29 Dollar";

            Game game3 = new Game();
            game3.GameId = 392;
            game3.GameCategoryId = 3;
            game3.GameName = "F1 2020";
            game3.GamePrice = "39 Dollar";

            Game game4 = new Game();
            game4.GameId = 882;
            game4.GameCategoryId = 4;
            game4.GameName = "Fall Guys";
            game4.GamePrice = "12 Dollar";

            Game game5 = new Game();
            game5.GameId = 281;
            game5.GameCategoryId = 5;
            game5.GameName = "Forza Horizon 4";
            game5.GamePrice = "59 USD";

            // Customers
            Customer customer1 = new Customer();
            customer1.CustomerId = 2285;
            customer1.NickName = "aliknr12";
            customer1.Country = "Turkey";
            customer1.GameSayisi = 2;

            Customer customer2 = new Customer();
            customer2.CustomerId = 1182;
            customer2.NickName = "MelekKonar";
            customer2.Country = "Turkey";
            customer2.GameSayisi = 1;

            Customer customer3 = new Customer();
            customer3.CustomerId = 1374;
            customer3.NickName = "JohnSmith";
            customer3.Country = "England";
            customer3.GameSayisi = 4;

            Customer customer4 = new Customer();
            customer4.CustomerId = 991;
            customer4.NickName = "ObabamaDereteynus";
            customer4.Country = "Africa";
            customer4.GameSayisi = 3;

            Customer customer5 = new Customer();
            customer5.CustomerId = 7001;
            customer5.NickName = "ElHabibiYaHabib";
            customer5.Country = "Suudi Arabistan";
            customer5.GameSayisi = 4;


            List<Customer> customers = new List<Customer> { customer1, customer2, customer3, customer4 };
            List<Game> games = new List<Game> { game1, game2, game3, game4 };


            GameManager gameManager = new GameManager();
            UserManager userManager = new UserManager();
            CustomerManager customerManager = new CustomerManager();
            

            
            customerManager.Save(customer2, game2);
            customerManager.Update(customer3);


            customers.Add(customer5);
            userManager.SignUp(customer5);

            customers.Remove(customer4);
            userManager.Delete(customer4);
            
            userManager.SignIn(customer1);
            userManager.LogOut(customer3);
            Console.WriteLine(" ");
            
            gameManager.BuyGame(customer2, game2);
            gameManager.RebateGame(game5,customer4);
            gameManager.BonusMoney(customer1, game1);







            
            
            










        }
    }
}
