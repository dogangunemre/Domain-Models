using Ohtap.ECommerce.Domain.Models.Core.Object;
using Ohtap.ECommerce.Domain.Models.Core.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Variations.Interfaces
{
    public interface IVariationItemList<T> : ILista<T>
        where T: IVariationIdentity
    {
    }
}
