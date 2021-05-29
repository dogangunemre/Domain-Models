using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductStatuses
{
    public interface IProductStatusList<T> : IProductStatusDataList<T>
        where T : IProductStatusData
    {
    }
}
