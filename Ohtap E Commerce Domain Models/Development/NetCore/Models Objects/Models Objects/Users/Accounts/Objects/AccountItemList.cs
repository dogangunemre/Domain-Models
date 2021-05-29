using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Accounts.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Accounts.Objects
{
    public class AccountItemList<T> : Lista<T>, IAccountItemList<T>
        where T : IAccountIdentity
    {
    }
}
