using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Customers
{
    public interface ICustomer : ICustomerData
    {
        Discounts.IDiscountDataList Discounts { get; set; }
        Currencies.CurrencyList Currencies { get; set; }
        Addresses.IAddressDataList Addresses { get; set; }
        Coupons.ICouponDataList Coupons { get; set; }

    }
}
