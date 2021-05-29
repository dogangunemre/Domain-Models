using Ohtap.ECommerce.Domain.Models.Objects.PropertyDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Properties
{
    public interface IProperty : IPropertyData
    {
        IPropertyDetailDataList<IPropertyDetailData> Details { set; get; }
      
    }
}
