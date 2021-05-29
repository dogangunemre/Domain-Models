using Ohtap.ECommerce.Domain.Models.Core.Object;
using Ohtap.ECommerce.Domain.Models.Core.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Measures.Interfaces
{
    public interface IMeasureItemList<T> : ILista<T>
        where T: IMeasureIdentity
    {
    }
}
