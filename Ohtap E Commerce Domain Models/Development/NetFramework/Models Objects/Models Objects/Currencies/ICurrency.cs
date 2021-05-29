﻿using Ohtap.ECommerce.Domain.Models.Objects.CurrencyDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Currencies
{
    public interface ICurrency : ICurrencyData
    {
        ICurrencyDetailList Details { set; get; }      
    }
}
