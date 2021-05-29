using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.BankAccounts.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.BankAccounts.Objects
{
    public class BankAccountItemList<T> : Lista<T>, IBankAccountItemList<T>
        where T : IBankAccountIdentity
    {
    }
}
