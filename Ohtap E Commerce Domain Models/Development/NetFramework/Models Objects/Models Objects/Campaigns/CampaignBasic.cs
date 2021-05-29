using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Campaigns
{
    public class CampaignBasic : ICampaignData
    {
        public virtual Files.IFileDataList Photos { get; set; }
        public virtual string ID { get; set; }
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual int Order { get; set; }
        public virtual string Description { get; set; }
        public virtual int State { get; set; }
        public virtual long StartDate { get; set; }
        public virtual long EndDate { get; set; }
    }
}
