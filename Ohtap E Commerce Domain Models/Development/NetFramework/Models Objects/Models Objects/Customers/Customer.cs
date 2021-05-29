using Ohtap.ECommerce.Domain.Models.Objects.Addresses;
using Ohtap.ECommerce.Domain.Models.Objects.Coupons;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Customers
{
    public class Customer : CustomerBasic, ICustomer
    {
        public virtual Discounts.IDiscountDataList Discounts { get; set; }
        public virtual CurrencyList Currencies { get; set; }
        public virtual IAddressDataList Addresses { get; set; }
        public virtual ICouponDataList Coupons { get; set; }
    }
}
