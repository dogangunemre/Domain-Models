﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Payments
{
    public interface IPaymentList<T> : IPaymentDataList<T>
        where T: IPaymentData
    {
    }
}