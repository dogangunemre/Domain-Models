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
    public class ProductSpecificationBasic : IProductSpecificationData
    {
        public string ID { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public string Value { get; set; }
        public ISpecificationData Specification { get; set; }
    }
}
