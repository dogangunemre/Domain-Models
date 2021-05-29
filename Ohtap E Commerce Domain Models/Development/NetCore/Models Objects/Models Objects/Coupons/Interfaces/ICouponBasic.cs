using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Coupons.Interfaces
{
    public interface ICouponBasic : IObjectBasic, ICouponInfo
    {
        long  EndDate { get; set; }
        long StartDate { get; set; }
    }
}
