using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Regions;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Regions
{
    public class RegionBasic : IRegionData
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public IRegion Parent { get; set; }
    }
}
