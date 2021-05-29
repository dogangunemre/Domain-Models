using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductGroups.Interfaces
{
    public interface IProductGroupBasic : IObjectBasic, IProductGroupInfo
    {
        string Symbol { get; set; }
        string FundCode { get; set; }
    }
}
