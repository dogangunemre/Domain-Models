using Ohtap.ECommerce.Domain.Models.Objects.MeasureDetails;
using Ohtap.ECommerce.Domain.Models.Objects.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Measures
{
    public interface IMeasure : IMeasureData
    {
        IUnitDataList<IUnitData> Units { get; set; }
        IMeasureDetailDataList<IMeasureDetailData> Details { set; get; }


    }
}
