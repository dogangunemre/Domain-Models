using Ohtap.ECommerce.Domain.Models.Serializable.Objects.LanguageDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.LanguageDetails;
using Ohtap.ECommerce.Domain.Models.Objects.Languages;
using System.Runtime.Serialization;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Languages
{
    [DataContract]
    [Serializable]
    public class Language : LanguageBasic, ILanguage
    {
        [DataMember]
        public LanguageDetails.LanguageDetailList Details { set; get; }




        ILanguageDetailDataList ILanguage.Details { get { return this.Details; } set { this.Details = (LanguageDetails.LanguageDetailList)value; } }
    }
}
