using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreSystem = Ohtap.ECommerce.Domain.Models.Core.System;

namespace Ohtap.ECommerce.Domain.Models.Objects.Languages
{
    public class LanguageList : CoreSystem.Lista<LanguageBasic>, ILanguageList<LanguageBasic>
    {
    }
}
