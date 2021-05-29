using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Regions
{
    public interface IRegion : IRegionData
    {
        
        RegionDetails.IRegionDetailDataList Details { set; get; }
        Taxes.ITaxData Tax { get; set; }
        Regions.IRegionList Childs { get; set; }
        new Regions.IRegion Parent { get; set; }
    }
}
