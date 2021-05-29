using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.OrderStatuses.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.OrderStatuses.Objects
{
    public class OrderStatusItemList<T> : Lista<T>, IOrderStatusItemList<T>
        where T : IOrderStatusIdentity
    {
    }
}
