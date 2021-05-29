using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.OrderStatuses
{
    public interface IOrderStatusList<T> : IOrderStatusDataList<T>
        where T : IOrderStatusData
    {
    }
}
