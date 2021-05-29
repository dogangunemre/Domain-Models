using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Serializable.Objects.UnitDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.UnitDetails;
using Ohtap.ECommerce.Domain.Models.Objects.Units;
using System.Runtime.Serialization;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Units
{
    [DataContract]
    [Serializable]
    public class Unit : UnitBasic, IUnit
    {
        [DataMember]
        public UnitDetails.UnitDetailList Details { get; set; }




        IUnitDetailDataList IUnit.Details { get { return this.Details; } set { this.Details = (UnitDetails.UnitDetailList)value; } }
    }
}
