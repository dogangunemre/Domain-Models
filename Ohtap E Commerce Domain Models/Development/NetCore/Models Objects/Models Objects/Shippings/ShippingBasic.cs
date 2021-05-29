using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Objects.Addresses;
using Ohtap.ECommerce.Domain.Models.Objects.Cargos;
using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.CargoStatuses;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Shippings
{
    public class ShippingBasic :Objecta,IShippingData
    {
        private string _ID;
        public virtual string ID { get => base.GetProperty(this._ID); set => base.SetProperty(ref this._ID, value); }

        private string _Code;
        public virtual string Code { get => base.GetProperty(this._Code); set => base.SetProperty(ref this._Code, value); }

        private string _Name;
        public virtual string Name { get => base.GetProperty(this._Name); set => base.SetProperty(ref this._Name, value); }

        private string _LastName;
        public virtual string LastName { get => base.GetProperty(this._LastName); set => base.SetProperty(ref this._LastName, value); }

        private int _Order;
        public virtual int Order { get => base.GetProperty(this._Order); set => base.SetProperty(ref this._Order, value); }

        private string _Description;
        public virtual string Description { get => base.GetProperty(this._Description); set => base.SetProperty(ref this._Description, value); }

        private int _State;
        public virtual int State { get => base.GetProperty(this._State); set => base.SetProperty(ref this._State, value); }

        private string _EMail;
        public virtual string EMail { get => base.GetProperty(this._EMail); set => base.SetProperty(ref this._EMail, value); }

        private string _Fax;
        public virtual string Fax { get => base.GetProperty(this._Fax); set => base.SetProperty(ref this._Fax, value); }

        private string _Phone;
        public virtual string Phone { get => base.GetProperty(this._Phone); set => base.SetProperty(ref this._Phone, value); }

        private Cargo _Cargo;
        public virtual Cargo Cargo { get => base.GetProperty(this._Cargo); set => base.SetProperty(ref this._Cargo, value); }
        ICargoData IShippingData.Cargo { get { return this.Cargo as ICargo; } set { this.Cargo = (Cargo)value; } }

        private CargoStatusBasic _CargoStatus;
        public virtual CargoStatusBasic CargoStatus { get => base.GetProperty(this._CargoStatus); set => base.SetProperty(ref this._CargoStatus, value); }

        private Address _Address;
        public virtual Address Address { get => base.GetProperty(this._Address); set => base.SetProperty(ref this._Address, value); }
        IAddressData IShippingData.Address { get { return this.Address as IAddress; } set { this.Address = (Address)value; } }


        private DataItemList _Dataset;
        public virtual DataItemList Dataset { get => base.GetProperty(this._Dataset); set => base.SetProperty(ref this._Dataset, value); }
        IDataItemList<IDataItemData> IShippingData.Dataset { get { return this.Dataset as IDataItemList<IDataItemData>; } set { this.Dataset = (DataItemList)value; } }

        public ShippingBasic()
        {
            this.Dataset = new DataItemList();
        }
    }
}
