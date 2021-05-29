using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Payments.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Payments.Objects
{
    public class PaymentItemList<T> : Lista<T>, IPaymentItemList<T>
        where T : IPaymentIdentity
    {
    }
}
