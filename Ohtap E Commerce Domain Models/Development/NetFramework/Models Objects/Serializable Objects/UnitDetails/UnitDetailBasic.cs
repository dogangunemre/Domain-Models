using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.UnitDetails;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.UnitDetails
{
    [DataContract]
    [Serializable]
    public class UnitDetailBasic : IUnitDetailData
    {
        [DataMember]
        public string ID { get; set; }
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Order { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int State { get; set; }
    }
}
