using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Addresses;
using Ohtap.ECommerce.Domain.Models.Objects.Stores;
using Ohtap.ECommerce.Domain.Models.Objects.Warehouses;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Stores
{
    public class Store : StoreBasic, IStore
    {
        public IAddressData Address { get; set; }
        public IWarehouseDataList Warehouses { get; set; }
    }
}
