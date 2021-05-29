
using Ohtap.ECommerce.Domain.Models.Serializable.Objects.CouponDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.CouponDetails;
using Ohtap.ECommerce.Domain.Models.Objects.Coupons;
using Ohtap.ECommerce.Domain.Models.Objects.Customers;
using Ohtap.ECommerce.Domain.Models.Objects.Files;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Coupons
{
    public class Coupon : CouponBasic, ICoupon
    {
        public IFileData Photo { get; set; }
        public ICustomerDataList Customers { get; set; }
        ICouponDetailDataList ICoupon.Details { get; set; }
    }
}
