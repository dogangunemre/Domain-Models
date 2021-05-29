using Ohtap.ECommerce.Domain.Models.Objects.CustomerGroupDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.CustomerGroups
{
    public interface ICustomerGroup : ICustomerGroupData
    {
        ICustomerGroupDetailDataList<ICustomerGroupDetailData> Childs { get; set; }
        ICustomerGroupDetailDataList<ICustomerGroupDetailData> Details { set; get; }
    }
}
