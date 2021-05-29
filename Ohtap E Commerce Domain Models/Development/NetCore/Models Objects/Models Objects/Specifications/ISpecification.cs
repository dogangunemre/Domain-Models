using Ohtap.ECommerce.Domain.Models.Objects.SpecificationDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Specifications
{
    public interface ISpecification : ISpecificationData
    {
        ISpecificationDetailDataList<ISpecificationDetailData> Details { set; get; }
      
    }
}
