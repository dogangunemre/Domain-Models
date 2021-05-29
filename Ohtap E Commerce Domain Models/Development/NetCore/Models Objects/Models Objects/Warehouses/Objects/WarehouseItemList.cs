using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Warehouses.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Warehouses.Objects
{
    public class WarehouseItemList<T> : Lista<T>, IWarehouseItemList<T>
        where T : IWarehouseIdentity
    {
    }
}
