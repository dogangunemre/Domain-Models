using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductSpecifications
{
    public interface IProductSpecificationData : CoreObject.IObjectID, CoreObject.IObjectOrder, CoreObject.IObjectDescription, CoreObject.IObjectState, IProductSpecificationValue, IProductSpecificationSpecification
    {
    }
}
