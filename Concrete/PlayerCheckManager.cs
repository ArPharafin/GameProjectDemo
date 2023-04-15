using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    internal class PlayerCheckManager : IPlayerCheckService
    {
        public bool CheckPlayer(Player player)
        {
            if (player.BirthYear == 2002 && player.FirstName == "Omer" && player.LastName == "Yilmaz" && player.NationalityID == "39045")
                return true;
            else return false;    
        }
        
    }
}
