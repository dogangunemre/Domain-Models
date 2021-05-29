using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Coupons
{
    public interface ICoupon : ICouponData
    {
        CouponDetails.ICouponDetailDataList<CouponDetails.ICouponDetailData> Details { set; get; }

        Files.IFileData Photo { get; set; }

        Customers.ICustomerDataList<Customers.ICustomerData> Customers { get; set; }
    }
}
