using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Measures.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Measures.Objects
{
    public class MeasureItemList<T> : Lista<T>, IMeasureItemList<T>
        where T : IMeasureIdentity
    {
    }
}
