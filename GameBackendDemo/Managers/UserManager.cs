using System;
using System.Collections.Generic;
using System.Text;
using GameBackendDemo.Entites;
using GameBackendDemo.Interfaces;

namespace GameBackendDemo.Managers
{
    public class UserManager : IUserService
    {
        public void Delete(Customer customer)
        {
            Console.WriteLine("---------");
            Console.WriteLine("[[Kullanıcı silindı...]]");
            Console.WriteLine("ID Number: " + customer.CustomerId);
            Console.WriteLine("Nickname: " + customer.NickName);
            Console.WriteLine("Country: " + customer.Country);
            Console.WriteLine("Oyun sayısı: " + customer.GameSayisi);
        }

        public void LogOut(Customer customer)
        {
            Console.WriteLine("---------");
            Console.WriteLine("[[Kullanıcı sistemden çıkış yaptı...]]");
            Console.WriteLine("ID Number: " + customer.CustomerId);
            Console.WriteLine("Nickname: " + customer.NickName);
            Console.WriteLine("Country: " + customer.Country);
            Console.WriteLine("Oyun sayısı: " + customer.GameSayisi);
        }

        public void SignIn(Customer customer)
        {
            Console.WriteLine("---------");
            Console.WriteLine("[[Kullanıcı giriş yaptı...]]");
            Console.WriteLine("ID Number: " + customer.CustomerId);
            Console.WriteLine("Nickname: " + customer.NickName);
            Console.WriteLine("Country: " + customer.Country);
            Console.WriteLine("Oyun sayısı: " + customer.GameSayisi);



        }

        public void SignUp(Customer customer)
        {
            Console.WriteLine("----------");
            Console.WriteLine("[[Kullanıcı eklendi...]]");
            Console.WriteLine("ID Number: " + customer.CustomerId);
            Console.WriteLine("Nickname: " + customer.NickName);
            Console.WriteLine("Country: " + customer.Country);
            
        }
    }
}
