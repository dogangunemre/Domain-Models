
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.SpecificationDetails;
using Ohtap.ECommerce.Domain.Models.Objects.Specifications;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Specifications
{
    public class Specification : SpecificationBasic, ISpecification
    {
        
        ISpecificationDetailDataList ISpecification.Details { get; set; }
    }
}
