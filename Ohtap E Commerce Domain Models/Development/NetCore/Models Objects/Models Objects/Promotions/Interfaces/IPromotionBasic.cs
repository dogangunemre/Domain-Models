using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Promotions.Interfaces
{
    public interface IPromotionBasic : IObjectBasic, IPromotionInfo
    {
        string Symbol { get; set; }
        string FundCode { get; set; }
    }
}
