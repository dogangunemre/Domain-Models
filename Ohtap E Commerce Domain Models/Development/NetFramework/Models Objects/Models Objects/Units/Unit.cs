using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.UnitDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Units
{
    public class Unit : UnitBasic, IUnit
    {
        
        IUnitDetailDataList IUnit.Details { get; set; }
    }
}
