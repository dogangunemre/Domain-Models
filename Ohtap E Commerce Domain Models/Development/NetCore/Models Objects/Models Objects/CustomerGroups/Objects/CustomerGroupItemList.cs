using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.CustomerGroups.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.CustomerGroups.Objects
{
    public class CustomerGroupItemList<T> : Lista<T>, ICustomerGroupItemList<T>
        where T : ICustomerGroupIdentity
    {
    }
}
