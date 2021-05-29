using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.VariationDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Variations
{
    public class Variation : VariationBasic, IVariation
    {
        public virtual Packages.IPackageDataList Packages { get; set; }

        public virtual IProductDataList Products { get; set; }
        IVariationDetailDataList IVariation.Details { get; set; }
    }
}
