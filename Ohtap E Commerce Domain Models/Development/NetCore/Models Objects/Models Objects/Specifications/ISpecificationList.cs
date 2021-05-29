using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Specifications
{
    public interface ISpecificationList<T> : ISpecificationDataList<T>
        where T: ISpecificationData
    {
    }
}
