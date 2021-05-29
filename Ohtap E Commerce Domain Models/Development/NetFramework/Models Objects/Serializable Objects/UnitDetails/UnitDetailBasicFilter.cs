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
    public class UnitDetailBasicFilter : UnitDetailBasic, IUnitDetailBasicFilter
    {
    }
}
