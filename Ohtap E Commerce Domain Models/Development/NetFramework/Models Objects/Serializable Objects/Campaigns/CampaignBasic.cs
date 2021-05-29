using Ohtap.ECommerce.Domain.Models.Objects.Campaigns;
using Ohtap.ECommerce.Domain.Models.Objects.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Campaigns
{
    public class CampaignBasic : ICampaignData
    {
        public IFileDataList Photos { get; set; }
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}
