using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Attributes;
using Ohtap.ECommerce.Domain.Models.Objects.ProductAttributes;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.ProductAttributes
{
    public class ProductAttributeBasic : IProductAttributeData
    {
        public int State { get; set; }
        public int Order { get; set; }
        public string ID { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public IAttributeData Attribute { get; set; }
    }
}
