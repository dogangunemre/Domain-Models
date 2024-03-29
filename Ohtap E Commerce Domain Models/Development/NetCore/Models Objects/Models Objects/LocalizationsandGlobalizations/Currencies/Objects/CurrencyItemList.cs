﻿using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Currencies.Objects
{
    public class CurrencyItemList<T> : Lista<T>, ICurrencyItemList<T>
        where T : ICurrencyIdentity
    {
    }
}
