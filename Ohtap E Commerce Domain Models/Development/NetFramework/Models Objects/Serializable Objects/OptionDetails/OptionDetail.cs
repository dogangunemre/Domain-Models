using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Languages;
using Ohtap.ECommerce.Domain.Models.Objects.OptionDetails;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.OptionDetails
{
    public class OptionDetail : OptionDetailBasic, IOptionDetail
    {
        ILanguage IOptionDetail.Language { get; set; }
    }
}
