using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.CouponDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Coupons
{
    public class Coupon : CouponBasic, ICoupon
    {
        public virtual Files.IFileData Photo { get; set; }
        public virtual Customers.ICustomerDataList Customers { get; set; }
        ICouponDetailDataList ICoupon.Details { get; set; }
    }
}
