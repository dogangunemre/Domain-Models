using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Labels.Interfaces
{
    public interface ILabelBasic : IObjectBasic, ILabelInfo
    {
        string Symbol { get; set; }
        string FundCode { get; set; }
    }
}
