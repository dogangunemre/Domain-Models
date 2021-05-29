using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Coupons.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Coupons.Objects
{
    public class CouponItemList<T> : Lista<T>, ICouponItemList<T>
        where T : ICouponIdentity
    {
    }
}
