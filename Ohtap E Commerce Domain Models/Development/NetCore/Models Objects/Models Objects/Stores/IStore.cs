using Ohtap.ECommerce.Domain.Models.Objects.Addresses;
using Ohtap.ECommerce.Domain.Models.Objects.Warehouses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Stores
{
    public interface IStore :IStoreData
    {
        IAddressData Address { get; set; }
        IWarehouseDataList<IWarehouseData> Warehouses { get; set; }
    }
}
