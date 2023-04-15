using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class eDevletManager : IPlayerCheckService
    {
        public bool CheckPlayer(Player player)
        {
            return true;
        }
    }
}
