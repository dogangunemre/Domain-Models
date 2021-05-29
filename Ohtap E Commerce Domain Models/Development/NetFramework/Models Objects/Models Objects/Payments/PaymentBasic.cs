using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Payments
{
    public class PaymentBasic : IPaymentData
    {
        public virtual string ID { get; set; }
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual int Order { get; set; }
        public virtual string Description { get; set; }
        public virtual int State { get; set; }
        public virtual string Title { get; set; }
        public virtual ICurrencyData Currency { get; set; }
        public virtual PaymentTypes Type { get; set; }
        public virtual decimal Amount { get; set; }
    }
}
