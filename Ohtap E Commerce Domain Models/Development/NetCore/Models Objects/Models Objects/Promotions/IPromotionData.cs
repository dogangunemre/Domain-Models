using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.Promotions
{
    public interface IPromotionData :  CoreObject.IObjectID, CoreObject.IObjectTitle, CoreObject.IObjectName, CoreObject.IObjectOrder, CoreObject.IObjectDescription, CoreObject.IObjectState, IPromotionEndDate, IPromotionStartDate
    {
        IDiscountData Discount { get; set; }
        IDataItemList<IDataItemData> Dataset { get; set; }
    }
}
