using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.Campaigns
{
    public class CampaignBasic : ICampaignData
    {
        public string Title { set; get; }
        public string Name { set; get; }
        public int Order { set; get; }
        public string Description { set; get; }
        public int State { set; get; }
        public string ID { set; get; }
        public string Photos { set; get; }
        public string EndDate { set; get; }
        public string StartDate { set; get; }

    }
}
