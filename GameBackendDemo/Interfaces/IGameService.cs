using GameBackendDemo.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendDemo.Interfaces
{
    public interface IGameService
    {
        void BuyGame(Customer customer,Game game);
        void RebateGame(Game game,Customer customer);
        void BonusMoney (Customer customer, Game game);
    }
}
