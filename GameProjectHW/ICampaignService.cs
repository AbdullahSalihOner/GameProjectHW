using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHW
{
    interface ICampaignService
    {
        void Start(Campaign campaign);
        void Finish(Campaign campaign);
        void Update(Campaign campaign);
    }
}
