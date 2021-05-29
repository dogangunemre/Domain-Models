using Ohtap.ECommerce.Domain.Models.Core.Object;
using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Coupons.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Coupons.Objects
{
    public class CouponExtended : CouponDetail, ICouponExtended
    {
        private Customers.CustomerList _Customers;
        public virtual Customers.CustomerList Customers { get => base.GetProperty(this._Customers); set => base.SetProperty(ref this._Customers, value); }
        

        
    }
}
