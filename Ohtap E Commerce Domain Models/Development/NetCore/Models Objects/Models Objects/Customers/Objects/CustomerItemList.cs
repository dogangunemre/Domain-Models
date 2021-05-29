using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Customers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Customers.Objects
{
    public class CustomerItemList<T> : Lista<T>, ICustomerItemList<T>
        where T : ICustomerIdentity
    {
    }
}
