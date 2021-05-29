using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.UnitDetails
{
    public interface IUnitDetailList<T> : IUnitDetailDataList<T>
        where T: IUnitDetailData
    {
    }
}
