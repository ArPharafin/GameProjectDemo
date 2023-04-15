using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Entities
{
    public class Campaing:IEntities
    {
        public  int CampaignID { get; set; }
        public string CampaignName{ get; set; }

        public DateTime CampaignDeadLine { get; set; }
        public int DiscountRate { get; set; }


    }
}
