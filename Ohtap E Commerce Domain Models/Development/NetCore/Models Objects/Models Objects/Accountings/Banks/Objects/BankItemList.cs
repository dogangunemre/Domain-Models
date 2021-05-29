using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Banks.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Banks.Objects
{
    public class BankItemList<T> : Lista<T>, IBankItemList<T>
        where T : IBankIdentity
    {
    }
}
