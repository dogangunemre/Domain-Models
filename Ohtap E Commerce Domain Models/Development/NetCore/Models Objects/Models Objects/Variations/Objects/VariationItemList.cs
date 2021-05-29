using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Variations.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Variations.Objects
{
    public class VariationItemList<T> : Lista<T>, IVariationItemList<T>
        where T : IVariationIdentity
    {
    }
}
