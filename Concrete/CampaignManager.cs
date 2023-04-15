using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void DeleteCampaign(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaignName + "named Campaign is deleted");
        }
        public void NewCampaign(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaignName + "named Campaign is added");
        }
        public void UpdateCampaign(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaignName+ " named Campaign is updated");

        }
    }
}
