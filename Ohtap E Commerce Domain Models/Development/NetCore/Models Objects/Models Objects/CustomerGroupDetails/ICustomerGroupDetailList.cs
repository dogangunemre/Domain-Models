using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.CustomerGroupDetails
{
    public interface ICustomerGroupDetailList<T> : ICustomerGroupDetailDataList<T>
        where T: ICustomerGroupDetailData
    {
    }
}
