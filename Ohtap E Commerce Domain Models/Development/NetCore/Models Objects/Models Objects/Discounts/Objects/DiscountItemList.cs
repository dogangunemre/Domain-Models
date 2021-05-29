using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Discounts.Objects
{
    public class DiscountItemList<T> : Lista<T>, IDiscountItemList<T>
        where T : IDiscountIdentity
    {
    }
}
