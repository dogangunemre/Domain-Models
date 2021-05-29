using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Packages
{
    public interface IPackageUnit
    {
        Units.IUnitData Unit { get; set; }
    }
}
