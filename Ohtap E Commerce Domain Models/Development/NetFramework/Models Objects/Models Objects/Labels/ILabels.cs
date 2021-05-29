using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Languages
{
    public interface ILanguage : ILanguageData
    {
        LanguageDetails.ILanguageDetailDataList Details { set; get; }
    }
}
