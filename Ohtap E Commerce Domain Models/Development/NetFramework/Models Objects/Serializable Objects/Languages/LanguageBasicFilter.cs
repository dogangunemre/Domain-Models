using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Languages;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Languages
{
    [DataContract]
    [Serializable]
    public class LanguageBasicFilter : LanguageBasic, ILanguageBasicFilter
    {
    }
}
