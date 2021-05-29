using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.LanguageDetails;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.LanguageDetails
{
    [DataContract]
    [Serializable]
    public class LanguageDetailBasicFilter : LanguageDetailBasic, ILanguageDetailBasicFilter
    {
    }
}
