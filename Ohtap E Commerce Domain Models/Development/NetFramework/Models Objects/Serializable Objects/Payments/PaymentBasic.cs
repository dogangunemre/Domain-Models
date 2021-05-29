using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Currencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using Ohtap.ECommerce.Domain.Models.Objects.Payments;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Payments
{
    public class PaymentBasic : IPaymentData
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public string Title { get; set; }
        public ICurrencyData Currency { get; set; }
        public PaymentTypes Type { get; set; }
        public decimal Amount { get; set; }
    }
}
