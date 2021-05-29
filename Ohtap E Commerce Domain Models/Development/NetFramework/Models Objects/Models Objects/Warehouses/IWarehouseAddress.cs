using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Warehouses
{
    public interface IWarehouseAddress
    {
        Addresses.IAddressData Address { get; set; }
    }
}
