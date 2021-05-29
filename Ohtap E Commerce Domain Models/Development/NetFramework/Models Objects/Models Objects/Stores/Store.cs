using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Stores
{
    public class Store : StoreBasic, IStore
    {
        public virtual Addresses.IAddressData Address { get; set; }
        public virtual Warehouses.IWarehouseDataList Warehouses { get; set; }
    }
}
