using Ohtap.ECommerce.Domain.Models.Objects.Addresses;
using Ohtap.ECommerce.Domain.Models.Objects.Warehouses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Stores
{
    public class Store : StoreBasic, IStore
    {

        private Address _Address;
        public virtual Address Address { get => base.GetProperty(this._Address); set => base.SetProperty(ref this._Address, value); }
        IAddressData IStore.Address { get { return this.Address as IAddress; } set { this.Address = (Address)value; } }


        private WarehouseList _Warehouses;
        public virtual WarehouseList Warehouses { get => base.GetProperty(this._Warehouses); set => base.SetProperty(ref this._Warehouses, value); }
        IWarehouseDataList<IWarehouseData> IStore.Warehouses { get { return this.Warehouses as IWarehouseDataList<IWarehouseData>; } set { this.Warehouses = (WarehouseList)value; } }

    }
}
