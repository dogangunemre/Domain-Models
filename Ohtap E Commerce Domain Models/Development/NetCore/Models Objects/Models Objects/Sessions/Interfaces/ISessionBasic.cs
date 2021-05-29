using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Sessions.Interfaces
{
    public interface ISessionBasic : IObjectBasic, ISessionInfo
    {
        string Symbol { get; set; }
        string FundCode { get; set; }
    }
}
