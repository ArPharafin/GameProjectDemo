using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface ICampaignService
    {
        void NewCampaign(Campaing campaing);
        void UpdateCampaign(Campaing campaing);
        void DeleteCampaign (Campaing campaing);


    }
}
