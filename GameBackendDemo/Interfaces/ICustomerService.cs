using System;
using System.Collections.Generic;
using System.Text;
using GameBackendDemo.Managers;
using GameBackendDemo.Entites;

namespace GameBackendDemo.Interfaces
{
    public interface ICustomerService
    {
        void Save(Customer customer,Game game);
        void Update(Customer customer);
        
        
        // real person control.
    }
}
