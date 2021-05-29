using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Accounts.Interfaces
{
    public interface IAccountBasic : IObjectBasic, IAccountInfo
    {
        string Symbol { get; set; }
        string FundCode { get; set; }
    }
}
