﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Prices
{
    public interface IPrice :IPriceData
    {
        Currencies.CurrencyList Currencies { get; set; }
    }
}