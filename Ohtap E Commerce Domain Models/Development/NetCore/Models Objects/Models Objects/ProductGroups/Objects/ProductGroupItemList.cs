using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.ProductGroups.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductGroups.Objects
{
    public class ProductGroupItemList<T> : Lista<T>, IProductGroupItemList<T>
        where T : IProductGroupIdentity
    {
    }
}
