using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendDemo.Entites
{
    public class Game
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public int GameCategoryId { get; set; }
        public string GamePrice { get; set; }
    }
}
