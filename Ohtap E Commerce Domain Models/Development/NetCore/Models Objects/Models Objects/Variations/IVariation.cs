using Ohtap.ECommerce.Domain.Models.Objects.Packages;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.VariationDetails;
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
        IProductDataList<IProductData> Products { get; set; }
        IPackageDataList<IPackageData> Packages { get; set; }
        IVariationDetailDataList<IVariationDetailData> Details { set; get; }

    }
}
