using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.AccountRoles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.AccountRoles.Objects
{
    public class AccountRoleItemList<T> : Lista<T>, IAccountRoleItemList<T>
        where T : IAccountRoleIdentity
    {
    }
}
