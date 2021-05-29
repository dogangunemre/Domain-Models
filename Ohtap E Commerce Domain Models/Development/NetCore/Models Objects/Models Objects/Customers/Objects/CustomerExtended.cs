using Ohtap.ECommerce.Domain.Models.Core.Object;
using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Customers.Interfaces;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using Ohtap.ECommerce.Domain.Models.Objects.Addresses;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;
using Ohtap.ECommerce.Domain.Models.Objects.Coupons;
using System;
using System.Collections.Generic;
using System.Text;
using Ohtap.ECommerce.Domain.Models.Objects.CustomerGroups;

namespace Ohtap.ECommerce.Domain.Models.Objects.Customers.Objects
{
    public class CustomerExtended : CustomerDetail, ICustomerExtended
    {
        private CurrencyList _Currencies;
        public virtual CurrencyList Currencies { get => base.GetProperty(this._Currencies); set => base.SetProperty(ref this._Currencies, value); }

        private AddressList _Addresses;
        public virtual AddressList Addresses { get => base.GetProperty(this._Addresses); set => base.SetProperty(ref this._Addresses, value); }

        private DiscountList _Discounts;
        public virtual DiscountList Discounts { get => base.GetProperty(this._Discounts); set => base.SetProperty(ref this._Discounts, value); }

        private CouponList _Coupons;
        public virtual CouponList Coupons { get => base.GetProperty(this._Coupons); set => base.SetProperty(ref this._Coupons, value); }

        ICustomerGroupDataList<ICustomerGroupData> Childs { get; set; }
    }
}
