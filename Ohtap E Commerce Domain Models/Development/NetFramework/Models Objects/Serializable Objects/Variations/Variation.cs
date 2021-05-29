using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Serializable.Objects.VariationDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Packages;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.VariationDetails;
using Ohtap.ECommerce.Domain.Models.Objects.Variations;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Variations
{
    public class Variation : VariationBasic, IVariation
    {
        public IPackageDataList Packages { get; set; }

        public IProductDataList Products { get; set; }
        IVariationDetailDataList IVariation.Details { get; set; }
    }
}
