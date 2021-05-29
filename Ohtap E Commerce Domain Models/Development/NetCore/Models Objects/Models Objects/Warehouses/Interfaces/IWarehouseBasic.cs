using Ohtap.ECommerce.Domain.Models.Core.Object;
using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Stores;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Warehouses.Interfaces
{
    public interface IWarehouseBasic : IObjectBasic, IWarehouseInfo
    {
        StoreBasic Store { get; set; }
    }
}
