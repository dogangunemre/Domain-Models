using Ohtap.ECommerce.Domain.Models.Objects.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductAttributes
{
    public interface IProductAttributeAttribute
    {
        public IAttributeData Attribute { get; set; }
    }
}
