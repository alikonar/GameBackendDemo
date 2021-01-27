using System;
using System.Collections.Generic;
using System.Text;
using GameBackendDemo.Entites;

namespace GameBackendDemo.Interfaces
{
    public interface IUserService
    {
        void SignUp(Customer customer);
        void SignIn(Customer customer);
        void LogOut(Customer customer);
        void Delete(Customer customer);
    }
}
