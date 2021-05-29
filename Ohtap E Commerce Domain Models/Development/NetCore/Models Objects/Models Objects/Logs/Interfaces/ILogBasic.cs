using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Logs.Interfaces
{
    public interface ILogBasic : IObjectBasic, ILogInfo
    {
        string Symbol { get; set; }
        string FundCode { get; set; }
    }
}
