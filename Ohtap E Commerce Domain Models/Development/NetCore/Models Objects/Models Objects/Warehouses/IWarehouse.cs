using Ohtap.ECommerce.Domain.Models.Objects.Addresses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Warehouses
{
    public interface IWarehouse : IWarehouseData
    {
        IAddressData Address { get; set; }

    }
}
