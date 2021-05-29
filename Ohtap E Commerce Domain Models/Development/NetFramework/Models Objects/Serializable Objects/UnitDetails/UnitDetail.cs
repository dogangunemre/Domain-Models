using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Languages;
using Ohtap.ECommerce.Domain.Models.Objects.UnitDetails;
using System.Runtime.Serialization;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.UnitDetails
{
    [DataContract]
    [Serializable]
    public class UnitDetail : UnitDetailBasic, IUnitDetail
    {
        [DataMember]
        public Languages.Language Language { get; set; }




        ILanguage IUnitDetail.Language { get { return this.Language; } set { this.Language = (Languages.Language)value; } }
    }
}
