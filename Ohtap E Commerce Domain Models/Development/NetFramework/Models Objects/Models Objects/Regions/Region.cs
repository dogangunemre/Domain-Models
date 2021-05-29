using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.RegionDetails;
using Ohtap.ECommerce.Domain.Models.Objects.Taxes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Regions
{
    public class Region : RegionBasic, IRegion
    {
        public virtual IRegionList Childs { get; set; }
        public virtual ITaxData Tax { get; set; }
        IRegionDetailDataList IRegion.Details { get; set; }
    }
}
