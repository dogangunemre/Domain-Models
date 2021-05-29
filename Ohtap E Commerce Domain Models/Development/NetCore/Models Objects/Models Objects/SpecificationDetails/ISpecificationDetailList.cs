using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.SpecificationDetails
{
    public interface ISpecificationDetailList<T> : ISpecificationDetailDataList<T>
        where T: ISpecificationDetailData
    {
    }
}
