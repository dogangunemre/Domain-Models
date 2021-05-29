using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Payments
{
    public interface IPaymentType
    {
        public PaymentTypes Type { get; set; }
    }
    public enum PaymentTypes
    {
        Cash,
        Credit,
        CashOnDelivery,
        CreditOnDelivery,
        Transfer
    }
}
