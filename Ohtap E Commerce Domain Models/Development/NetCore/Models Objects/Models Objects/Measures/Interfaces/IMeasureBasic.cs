using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Measures.Interfaces
{
    public interface IMeasureBasic : IObjectBasic, IMeasureInfo
    {
        string Symbol { get; set; }
        string FundCode { get; set; }
    }
}
