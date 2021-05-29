using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Languages;
using Ohtap.ECommerce.Domain.Models.Objects.MeasureDetails;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.MeasureDetails
{
    public class MeasureDetail : MeasureDetailBasic, IMeasureDetail
    {
        ILanguage IMeasureDetail.Language { get; set; }
    }
}
