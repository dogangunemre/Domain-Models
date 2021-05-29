using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Payments
{
    public interface IPayment : IPaymentData
    {
        Banks.IBankData Bank { get; set; }
        Customers.ICustomerData Customer { get; set; }
        Currencies.ICurrencyData Currencya { get; set; }
    }
}
