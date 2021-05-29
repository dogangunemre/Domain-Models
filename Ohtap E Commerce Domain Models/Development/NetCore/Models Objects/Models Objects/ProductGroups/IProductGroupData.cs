using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Objects.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductGroups
{
    public interface IProductGroupData :  CoreObject.IObjectID, CoreObject.IObjectCode, CoreObject.IObjectName, CoreObject.IObjectOrder, CoreObject.IObjectDescription, CoreObject.IObjectState
    {
        IProductGroupData Parent { get; set; }
        IFileData Photo { get; set; }
        IDataItemList<IDataItemData> Dataset { get; set; }
    }
}
