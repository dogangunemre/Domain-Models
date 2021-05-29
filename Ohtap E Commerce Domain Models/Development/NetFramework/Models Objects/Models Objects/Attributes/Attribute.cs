using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.AttributeDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Attributes
{
    public  class Attribute : AttributeBasic, IAttribute
    {
        
        IAttributeDetailDataList IAttribute.Details { get; set; }
    }
}
