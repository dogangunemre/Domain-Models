using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Shippings.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Shippings.Objects
{
    public class ShippingItemList<T> : Lista<T>, IShippingItemList<T>
        where T : IShippingIdentity
    {
    }
}
