using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Coupons
{
    public class CouponBasic : Objecta,ICouponData
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

        private long _StartDate;
        public virtual long StartDate { get => base.GetProperty(this._StartDate); set => base.SetProperty(ref this._StartDate, value); }


        private long _EndDate;
        public virtual long EndDate { get => base.GetProperty(this._EndDate); set => base.SetProperty(ref this._EndDate, value); }


        private Discount _Discount;
        public virtual Discount Discount { get => base.GetProperty(this._Discount); set => base.SetProperty(ref this._Discount, value); }
        IDiscountData ICouponDiscount.Discount { get { return this.Discount as IDiscountData; } set { this.Discount = (Discount)value; } }


        private DataItemList _Dataset;
        public virtual DataItemList Dataset { get => base.GetProperty(this._Dataset); set => base.SetProperty(ref this._Dataset, value); }
        IDataItemList<IDataItemData> ICouponData.Dataset { get { return this.Dataset as IDataItemList<IDataItemData>; } set { this.Dataset = (DataItemList)value; } }

        public CouponBasic()
        {
            this.Dataset = new DataItemList();
        }
    }
}
