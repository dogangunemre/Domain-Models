using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Campaigns.Interfaces
{
    public interface ICampaignBasic : IObjectBasic, ICampaignInfo
    {
        
        public  long StartDate { get; set; }

        public long EndDate { get; set; }


        
        
    }
}
