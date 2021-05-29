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
    public class LanguageBasic : ILanguageData
    {
        [DataMember]
        public string ID { set; get; }
        [DataMember]
        public string Code { set; get; }
        [DataMember]
        public string Name { set; get; }
        [DataMember]
        public string LanguageCode { set; get; }
        [DataMember]
        public int Order { set; get; }
        [DataMember]
        public string Description { set; get; }
        [DataMember]
        public int State { set; get; }
    }
}
