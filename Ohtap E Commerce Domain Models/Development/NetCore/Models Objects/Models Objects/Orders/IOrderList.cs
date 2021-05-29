using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Orders
{
    public interface IOrderList<T> : IOrderDataList<T>
        where T : IOrderData
    {
    }
}
