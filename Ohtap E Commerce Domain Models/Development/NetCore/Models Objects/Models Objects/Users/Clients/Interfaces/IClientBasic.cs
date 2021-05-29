using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Clients.Interfaces
{
    public interface IClientBasic : IObjectBasic, IClientInfo
    {
        string Symbol { get; set; }
        string FundCode { get; set; }
    }
}
