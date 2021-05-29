using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Units.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Units.Objects
{
    public class UnitItemList<T> : Lista<T>, IUnitItemList<T>
        where T : IUnitIdentity
    {
    }
}
