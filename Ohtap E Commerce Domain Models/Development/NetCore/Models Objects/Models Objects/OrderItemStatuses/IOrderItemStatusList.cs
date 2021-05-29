using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.OrderItemStatuses
{
    public interface IOrderItemStatusList<T> : IOrderItemStatusDataList<T>
        where T : IOrderItemStatusData
    {
    }
}
