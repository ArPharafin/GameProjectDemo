using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class CommunityManager : ICommunityService
    {
        public void Friendship(Player player, Player player1)
        {
            Console.WriteLine("Friendship between " + player + " " + player1 + " is been succesful");
        }

        public void SupportforCampaign(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaignID+"Id'ed campaign is under  investigate by our support team");
        }
        public void SupportforPlayer(Player player)
        {
            Console.WriteLine(player.Id+"Id'ed player is under investigate by our support team");
        }

        public void SupportforProduct(Product product)
        {
            Console.WriteLine(product.ProductID+" Id'ed product is under investigate by our support team");
        }
    }
}
