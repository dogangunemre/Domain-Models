using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Objects.Units;
using Ohtap.ECommerce.Domain.Models.Objects.Warehouses;
using System;
using System.Collections.Generic;
using System.Text;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;


namespace Ohtap.ECommerce.Domain.Models.Objects.Products
{
    public interface IProductStockData: CoreObject.IObjectID, CoreObject.IObjectCode, CoreObject.IObjectName, CoreObject.IObjectOrder, CoreObject.IObjectDescription, CoreObject.IObjectState
    {
        public WarehouseBasic Warehouse  { get; set; }
        public UnitBasic Unit { get; set; }
        public decimal Amount { get; set; }
        IDataItemList<IDataItemData> Dataset { get; set; }
    }
}
