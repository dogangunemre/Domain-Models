﻿using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.BankAccounts.Interfaces
{
    public interface IBankAccountBasicFilter : IObjectBasicFilter, IBankAccountInfoFilter
    {
    }
}
