using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.OrderItemStatuses.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.OrderItemStatuses.Objects
{
    public class OrderItemStatusItemList<T> : Lista<T>, IOrderItemStatusItemList<T>
        where T : IOrderItemStatusIdentity
    {
    }
}
