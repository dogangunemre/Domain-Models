using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Core.System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using Ohtap.ECommerce.Domain.Models.Objects.Regions;

namespace Ohtap.ECommerce.Domain.Models.Objects.Prices
{
    public class PriceBasic :Objecta, IPriceData
    {
        private string _ID;
        public virtual string ID { get => base.GetProperty(this._ID); set => base.SetProperty(ref this._ID, value); }

        private string _Code;
        public virtual string Code { get => base.GetProperty(this._Code); set => base.SetProperty(ref this._Code, value); }

        private string _Name;
        public virtual string Name { get => base.GetProperty(this._Name); set => base.SetProperty(ref this._Name, value); }

        private int _Order;
        public virtual int Order { get => base.GetProperty(this._Order); set => base.SetProperty(ref this._Order, value); }

        private string _Description;
        public virtual string Description { get => base.GetProperty(this._Description); set => base.SetProperty(ref this._Description, value); }

        private int _State;
        public virtual int State { get => base.GetProperty(this._State); set => base.SetProperty(ref this._State, value); }

        private decimal _Value;
        public virtual decimal Value { get => base.GetProperty(this._Value); set => base.SetProperty(ref this._Value, value); }

        private CurrencyBasic _Currency;
        public virtual CurrencyBasic Currency { get => base.GetProperty(this._Currency); set => base.SetProperty(ref this._Currency, value); }

        private DataItemList _Dataset;
        public virtual DataItemList Dataset { get => base.GetProperty(this._Dataset); set => base.SetProperty(ref this._Dataset, value); }
        IDataItemList<IDataItemData> IPriceData.Dataset { get { return this.Dataset as IDataItemList<IDataItemData>; } set { this.Dataset = (DataItemList)value; } }

   

        public PriceBasic()
        {
            this.Dataset = new DataItemList();
        }
    }
}
