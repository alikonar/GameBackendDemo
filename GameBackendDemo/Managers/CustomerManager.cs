using GameBackendDemo.Entites;
using GameBackendDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text; 

namespace GameBackendDemo.Managers
{
    public class CustomerManager : ICustomerService
    {
        public void Save(Customer customer,Game game)
        {
            Console.WriteLine("Checkpoint saved.."+"| User: >>>  "+customer.NickName+"  "+"||Game :>>"+" "+game.GameName);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Information updated..."+"User: >>>   "+customer.NickName);
        }
    }
}
