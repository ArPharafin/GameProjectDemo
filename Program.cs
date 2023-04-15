using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
public  class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new PlayerCheckManager());
            playerManager.Add(new Player { Id = 1, BirthYear = 2002, FirstName = "Omer", LastName = "Yilmaz", NationalityID = "39045" });
        
        }
    }
}
