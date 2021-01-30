using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHW
{
    class CampaignManager : ICampaignService
    {
        public void Finish(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Kampanyası Sona Erdi");
        }

        public void Start(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Kampanyası Başladı");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Kampanyası Güncellendi");
        }
    }
}
