using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Promotions.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Promotions.Objects
{
    public class PromotionItemList<T> : Lista<T>, IPromotionItemList<T>
        where T : IPromotionIdentity
    {
    }
}
