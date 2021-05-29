using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Variations
{
    public interface IVariation : IVariationData
    {
        Packages.IPackageDataList Packages { get; set; }
        VariationDetails.IVariationDetailDataList Details { set; get; }
        Products.IProductDataList Products { get; set; }

        

    }
}
