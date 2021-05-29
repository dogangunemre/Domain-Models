using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Addresses;
using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Coupons;
using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Currencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Addresses;
using Ohtap.ECommerce.Domain.Models.Objects.Coupons;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using Ohtap.ECommerce.Domain.Models.Objects.Customers;


namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Customers
{
    public class Customer : CustomerBasic, ICustomer
    {
        public IDiscountDataList Discounts { get; set; }
        public ICurrencyDataList Currencies { get; set; }
        public IAddressDataList Addresses { get; set; }
        public ICouponDataList Coupons { get; set; }
    }
}
