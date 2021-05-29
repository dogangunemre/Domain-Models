using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using Ohtap.ECommerce.Domain.Models.Core.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Payments
{
    public class PaymentBasic :Objecta, IPaymentData
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

        private string _Title;
        public virtual string Title { get => base.GetProperty(this._Title); set => base.SetProperty(ref this._Title, value); }

        private  PaymentTypes _Type;
        public virtual PaymentTypes Type { get => base.GetProperty(this._Type); set => base.SetProperty(ref this._Type, value); }

        private decimal _Amount;
        public virtual decimal Amount { get => base.GetProperty(this._Amount); set => base.SetProperty(ref this._Amount, value); }



        private Currency _Currency;
        public virtual Currency Currency { get => base.GetProperty(this._Currency); set => base.SetProperty(ref this._Currency, value); }
        ICurrencyData IPaymentData.Currency { get { return this.Currency as ICurrencyData; } set { this.Currency = (Currency)value; } }

        private DataItemList _Dataset;
        public virtual DataItemList Dataset { get => base.GetProperty(this._Dataset); set => base.SetProperty(ref this._Dataset, value); }
        IDataItemList<IDataItemData> IPaymentData.Dataset { get { return this.Dataset as IDataItemList<IDataItemData>; } set { this.Dataset = (DataItemList)value; } }

        public PaymentBasic()
        {
            this.Dataset = new DataItemList();
        }

    }
}
