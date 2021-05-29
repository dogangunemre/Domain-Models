using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.OrderItems.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.OrderItems.Objects
{
    public class OrderItemItemList<T> : Lista<T>, IOrderItemItemList<T>
        where T : IOrderItemIdentity
    {
    }
}
