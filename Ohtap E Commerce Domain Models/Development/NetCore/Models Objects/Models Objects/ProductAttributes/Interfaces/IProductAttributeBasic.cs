using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductAttributes.Interfaces
{
    public interface IProductAttributeBasic : IObjectBasic, IProductAttributeInfo
    {
        string Symbol { get; set; }
        string FundCode { get; set; }
    }
}
