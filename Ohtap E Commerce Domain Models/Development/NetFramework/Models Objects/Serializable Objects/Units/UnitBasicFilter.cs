using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Units;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Units
{
    [DataContract]
    [Serializable]
    public class UnitBasicFilter : UnitBasic, IUnitBasicFilter
    {
    }
}
