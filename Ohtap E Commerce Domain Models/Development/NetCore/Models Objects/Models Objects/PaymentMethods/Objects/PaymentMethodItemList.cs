﻿using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.PaymentMethods.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.PaymentMethods.Objects
{
    public class PaymentMethodItemList<T> : Lista<T>, IPaymentMethodItemList<T>
        where T : IPaymentMethodIdentity
    {
    }
}
