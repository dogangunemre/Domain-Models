using Ohtap.ECommerce.Domain.Models.Objects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;

namespace Ohtap.ECommerce.Domain.Models.Objects.Payments
{
    public class Payment : PaymentBasic, IPayment
    {
        public virtual Banks.IBankData Bank { get; set; }
        public virtual Customers.ICustomerData Customer { get; set; }
        public virtual ICurrencyData Currencya { get; set; }
    }
}
