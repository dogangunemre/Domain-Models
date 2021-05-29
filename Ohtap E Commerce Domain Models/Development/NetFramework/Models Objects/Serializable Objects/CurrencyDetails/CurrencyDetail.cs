using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.CurrencyDetails;
using Ohtap.ECommerce.Domain.Models.Objects.Languages;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.CurrencyDetails
{
    public class CurrencyDetail : CurrencyDetailBasic, ICurrencyDetail
    {
        ILanguage ICurrencyDetail.Language { get; set; }
    }
}
