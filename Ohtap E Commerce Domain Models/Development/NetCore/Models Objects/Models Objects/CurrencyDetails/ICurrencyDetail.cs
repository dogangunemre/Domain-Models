﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.CurrencyDetails
{
    public interface ICurrencyDetail : ICurrencyDetailData
    {
        Languages.ILanguage Language { get; set; }
    }
}
