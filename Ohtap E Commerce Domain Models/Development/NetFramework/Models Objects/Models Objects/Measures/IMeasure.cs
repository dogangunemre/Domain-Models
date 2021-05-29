using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Measures
{
    public interface IMeasure : IMeasureData
    {
        MeasureDetails.IMeasureDetailDataList Details { set; get; }

        Units.IUnitDataList Units { get; set; }

    }
}
