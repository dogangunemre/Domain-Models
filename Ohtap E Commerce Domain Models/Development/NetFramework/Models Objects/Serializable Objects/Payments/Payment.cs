using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Banks;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using Ohtap.ECommerce.Domain.Models.Objects.Customers;
using Ohtap.ECommerce.Domain.Models.Objects.Payments;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Payments
{
    public class Payment : PaymentBasic, IPayment
    {
        public IBankData Bank { get; set; }
        public ICustomerData Customer { get; set; }
        public ICurrencyData Currencya { get; set; }
    }
}
