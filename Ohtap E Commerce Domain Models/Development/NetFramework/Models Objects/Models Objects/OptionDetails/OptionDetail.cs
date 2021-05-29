using Ohtap.ECommerce.Domain.Models.Objects.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.OptionDetails
{
    public class OptionDetail : OptionDetailBasic, IOptionDetail
    {
        ILanguage IOptionDetail.Language { get; set; }
    }
}
