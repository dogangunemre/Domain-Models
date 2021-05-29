using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Objects.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductAttributes
{
    public interface IProductAttributeData : CoreObject.IObjectState, CoreObject.IObjectOrder, CoreObject.IObjectID, CoreObject.IObjectDescription, IProductAttributeValue
    {
        IAttributeData Attribute { get; set; }
        IDataItemList<IDataItemData> Dataset { get; set; }
    }
}
