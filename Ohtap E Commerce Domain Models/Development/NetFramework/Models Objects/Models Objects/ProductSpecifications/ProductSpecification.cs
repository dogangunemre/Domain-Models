using Ohtap.ECommerce.Domain.Models.Objects.LanguageDetails;
using Ohtap.ECommerce.Domain.Models.Objects.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductSpecifications
{
    public class ProductSpecification : ProductSpecificationBasic, IProductSpecification
    {
        public virtual ISpecificationData Specifications { get; set; }
    }
}
