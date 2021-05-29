using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Orders
{
    public interface IOrderStore
    {
        Stores.IStoreData Store { get; set; }
    }
}
