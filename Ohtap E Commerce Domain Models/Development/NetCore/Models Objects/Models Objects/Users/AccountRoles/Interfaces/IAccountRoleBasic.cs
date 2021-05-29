using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.AccountRoles.Interfaces
{
    public interface IAccountRoleBasic : IObjectBasic, IAccountRoleInfo
    {
        string Symbol { get; set; }
        string FundCode { get; set; }
    }
}
