using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductLabels.Interfaces
{
    public interface IProductLabelBasic : IObjectBasic, IProductLabelInfo
    {
        string Symbol { get; set; }
        string FundCode { get; set; }
    }
}
