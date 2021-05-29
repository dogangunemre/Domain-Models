using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Addresses
{
    public class AddressBasic : Objecta, IAddressData
    {
        private string _ID;
        public virtual string ID { get => base.GetProperty(this._ID); set => base.SetProperty(ref this._ID, value); }

        private string _Title;
        public virtual string Title { get => base.GetProperty(this._Title); set => base.SetProperty(ref this._Title, value); }

        private int _Order;
        public virtual int Order { get => base.GetProperty(this._Order); set => base.SetProperty(ref this._Order, value); }

        private string _Description;
        public virtual string Description { get => base.GetProperty(this._Description); set => base.SetProperty(ref this._Description, value); }

        private int _State;
        public virtual int State { get => base.GetProperty(this._State); set => base.SetProperty(ref this._State, value); }

        private string _FullAddress;
        public virtual string FullAddress { get => base.GetProperty(this._FullAddress); set => base.SetProperty(ref this._FullAddress, value); }

        private string _PostCode;
        public virtual string PostCode { get => base.GetProperty(this._PostCode); set => base.SetProperty(ref this._PostCode, value); }

        private string _Country;
        public virtual string Country { get => base.GetProperty(this._Country); set => base.SetProperty(ref this._Country, value); }

        private string _City;
        public virtual string City { get => base.GetProperty(this._City); set => base.SetProperty(ref this._City, value); }


        private DataItemList _Dataset;
        public virtual DataItemList Dataset { get => base.GetProperty(this._Dataset); set => base.SetProperty(ref this._Dataset, value); }
        IDataItemList<IDataItemData> IAddressData.Dataset { get { return this.Dataset as IDataItemList<IDataItemData>; } set { this.Dataset = (DataItemList)value; } }

        public AddressBasic()
        {
            this.Dataset = new DataItemList();
        }
    }
}
