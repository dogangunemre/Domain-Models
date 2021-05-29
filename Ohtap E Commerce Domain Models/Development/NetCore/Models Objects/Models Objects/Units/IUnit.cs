using Ohtap.ECommerce.Domain.Models.Objects.UnitDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Units
{
    public interface IUnit : IUnitData
    {
        IUnitDetailDataList<IUnitDetailData> Details { set; get; }
      
    }
}
