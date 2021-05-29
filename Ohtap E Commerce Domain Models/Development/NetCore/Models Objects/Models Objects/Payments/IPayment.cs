using Ohtap.ECommerce.Domain.Models.Objects.Banks;
using Ohtap.ECommerce.Domain.Models.Objects.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Payments
{
    public interface IPayment : IPaymentData
    {
        IBankData Bank { get; set; }
        ICustomerData Customer { get; set; }
    }
}
