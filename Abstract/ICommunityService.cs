using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface ICommunityService
    {

        void SupportforPlayer(Player player);
        void SupportforProduct(Product product);
        void SupportforCampaign(Campaing campaing);
        void Friendship(Player player,Player player1);



    }
}
