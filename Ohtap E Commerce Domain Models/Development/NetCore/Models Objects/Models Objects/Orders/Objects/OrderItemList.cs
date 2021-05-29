using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Orders.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Orders.Objects
{
    public class OrderItemList<T> : Lista<T>, IOrderItemList<T>
        where T : IOrderIdentity
    {
    }
}
