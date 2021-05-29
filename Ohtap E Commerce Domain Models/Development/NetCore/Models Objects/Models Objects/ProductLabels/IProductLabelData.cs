using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Objects.Labels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;


namespace Ohtap.ECommerce.Domain.Models.Objects.ProductLabels
{
    public interface IProductLabelData : CoreObject.IObjectID, CoreObject.IObjectCode, CoreObject.IObjectName, CoreObject.IObjectOrder, CoreObject.IObjectDescription, CoreObject.IObjectState, IProductLabelValue
    {
        ILabelData Label { get; set; }
        IDataItemList<IDataItemData> Dataset { get; set; }
    }
}
