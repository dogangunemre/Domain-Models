using Ohtap.ECommerce.Domain.Models.Objects.RegionDetails;
using Ohtap.ECommerce.Domain.Models.Objects.Taxes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Regions
{
    public interface IRegion : IRegionData
    {
        IRegionDataList<IRegionData> Childs { get; set; }
        IRegionDetailDataList<IRegionDetailData> Details { set; get; }
        ITaxData Tax { get; set; }
    }
}
