using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductCategories.Interfaces
{
    public interface IProductCategoryBasic : IObjectBasic, IProductCategoryInfo
    {
        string Symbol { get; set; }
        string FundCode { get; set; }
    }
}
