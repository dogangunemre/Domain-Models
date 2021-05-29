﻿using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Prices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Prices.Objects
{
    public class PriceItemList<T> : Lista<T>, IPriceItemList<T>
        where T : IPriceIdentity
    {
    }
}
