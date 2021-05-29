using Ohtap.ECommerce.Domain.Models.Serializable.Objects.MeasureDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.MeasureDetails;
using Ohtap.ECommerce.Domain.Models.Objects.Measures;
using Ohtap.ECommerce.Domain.Models.Objects.Units;
namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Measures
{
    public class Measure : MeasureBasic, IMeasure
    {
        public IUnitDataList Units { get; set; }
        IMeasureDetailDataList IMeasure.Details { get; set; }
    }
}
