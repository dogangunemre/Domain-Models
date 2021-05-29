using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Currencies.Interfaces
{
    public interface ICurrencyBasic : IObjectBasic, ICurrencyInfo
    {
        string Symbol { get; set; }
        string FundCode { get; set; }
    }
}
