using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.PaymentStatuses.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.PaymentStatuses.Objects
{
    public class PaymentStatusItemList<T> : Lista<T>, IPaymentStatusItemList<T>
        where T : IPaymentStatusIdentity
    {
    }
}
