using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class PlayerManager : IPlayerService
    {
        IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }
        public void Add(Player player)
        {
            if(_playerCheckService.CheckPlayer(player)==true)
            Console.WriteLine(player.Id+" Id'ed Player is added");
            else Console.WriteLine(player.Id+" Id'ed Player is not a valid Player");
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.Id+" Id'ed Player is deleted");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.Id+" Id'ed Player is updated");
        }
    }
}
