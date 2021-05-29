using Ohtap.ECommerce.Domain.Models.Serializable.Objects.AttributeDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Attributes;
using Ohtap.ECommerce.Domain.Models.Objects.AttributeDetails;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Attributes
{
    public class Attribute : AttributeBasic, IAttribute
    {
        
        IAttributeDetailDataList IAttribute.Details { get; set; }
    }
}
