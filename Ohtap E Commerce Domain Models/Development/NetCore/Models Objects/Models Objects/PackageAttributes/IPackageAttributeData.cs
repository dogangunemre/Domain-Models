using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Objects.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.PackageAttributes
{
    public interface IPackageAttributeData :  CoreObject.IObjectID, CoreObject.IObjectOrder, CoreObject.IObjectDescription, CoreObject.IObjectState, IPackageAttributeValue
    {
        IAttributeData Attribute { get; set; }
        IDataItemList<IDataItemData> Dataset { get; set; }
    }
}
