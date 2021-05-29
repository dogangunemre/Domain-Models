using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.LanguageDetails
{
    public interface ILanguageDetailList<T> : ILanguageDetailDataList<T>
        where T : ILanguageDetailData
    {
    }
}
