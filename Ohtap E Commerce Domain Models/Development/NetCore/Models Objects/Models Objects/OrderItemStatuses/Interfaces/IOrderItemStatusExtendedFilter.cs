using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.OrderItemStatuses.Interfaces
{
    public interface IOrderItemStatusExtendedFilter : IObjectExtendedFilter, IOrderItemStatusDetailFilter
    {
    }
}
