using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Objects.OrderItems;
using Ohtap.ECommerce.Domain.Models.Objects.Packages;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.Prices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.OrderItems
{
    public interface IOrderItemData :  CoreObject.IObjectID, CoreObject.IObjectOrder, CoreObject.IObjectDescription, CoreObject.IObjectState, CoreObject.IObjectName, IOrderItemAmount, IOrderItemType
    {
        IProductData Product { get; set; }
        IPackageData Package { get; set; }
        IPriceData Price { get; set; }
        IDataItemList<IDataItemData> Dataset { get; set; }
    }
}
