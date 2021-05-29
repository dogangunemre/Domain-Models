using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.ProductCategories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductCategories.Objects
{
    public class ProductCategoryItemList<T> : Lista<T>, IProductCategoryItemList<T>
        where T : IProductCategoryIdentity
    {
    }
}
