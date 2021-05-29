using Ohtap.ECommerce.Domain.Models.Objects.Addresses;
using Ohtap.ECommerce.Domain.Models.Core.System;

using Ohtap.ECommerce.Domain.Models.Objects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Warehouses
{
    public class Warehouse : WarehouseBasic, IWarehouse
    {
        private Address _Address;
        public virtual Address Address { get => base.GetProperty(this._Address); set => base.SetProperty(ref this._Address, value); }
        IAddressData IWarehouse.Address { get { return this.Address as IAddress; } set { this.Address = (Address)value; } }




        



    }
}
