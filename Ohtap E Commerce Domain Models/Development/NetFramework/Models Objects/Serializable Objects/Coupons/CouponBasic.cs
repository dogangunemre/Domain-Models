using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Coupons;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Coupons
{
    public class CouponBasic : ICouponData
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public IDiscountData Discount { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}
