using Ohtap.ECommerce.Domain.Models.Serializable.Objects.LanguageDetails;
using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.ProductSpecifications;
using Ohtap.ECommerce.Domain.Models.Objects.Specifications;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.ProductSpecifications
{
    public class ProductSpecification : ProductSpecificationBasic, IProductSpecification
    {
        public ISpecificationData Specifications { get; set; }
    }
}
