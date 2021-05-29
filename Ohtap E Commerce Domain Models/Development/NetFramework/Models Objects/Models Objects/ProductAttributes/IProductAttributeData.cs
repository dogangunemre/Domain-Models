using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductAttributes
{
    public interface IProductAttributeData : CoreObject.IObjectState, CoreObject.IObjectOrder, CoreObject.IObjectID, CoreObject.IObjectDescription, IProductAttributeValue, IProductAttributeAttribute
    {
    }
}
