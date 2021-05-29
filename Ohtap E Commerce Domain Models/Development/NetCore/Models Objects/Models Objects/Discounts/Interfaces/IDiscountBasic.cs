using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Discounts.Interfaces
{
    public interface IDiscountBasic : IObjectBasic, IDiscountInfo
    {
        string Symbol { get; set; }
        string FundCode { get; set; }
    }
}
