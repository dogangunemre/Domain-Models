using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Serializable.Objects.RegionDetails;
using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Taxes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.RegionDetails;
using Ohtap.ECommerce.Domain.Models.Objects.Regions;
using Ohtap.ECommerce.Domain.Models.Objects.Taxes;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Regions
{
    public class Region : RegionBasic, IRegion
    {
        public IRegionList Childs { get; set; }
        public ITaxData Tax { get; set; }
        IRegionDetailDataList IRegion.Details { get; set; }
    }
}
