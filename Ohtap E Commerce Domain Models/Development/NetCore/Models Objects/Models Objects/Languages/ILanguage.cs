using Ohtap.ECommerce.Domain.Models.Objects.LanguageDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Languages
{
    public interface ILanguage : ILanguageData
    {
        ILanguageDetailDataList<ILanguageDetailData> Details { set; get; }
    }
}
