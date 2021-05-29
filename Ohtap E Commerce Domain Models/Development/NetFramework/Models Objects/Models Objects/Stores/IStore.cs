using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Stores
{
    public interface IStore :IStoreData
    {
        Addresses.IAddressData Address { get; set; }
        Warehouses.IWarehouseDataList Warehouses { get; set; }
    }
}
