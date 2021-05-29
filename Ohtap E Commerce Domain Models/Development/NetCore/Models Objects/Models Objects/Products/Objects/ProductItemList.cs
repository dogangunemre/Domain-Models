using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Products.Objects
{
    public class ProductItemList<T> : Lista<T>, IProductItemList<T>
        where T : IProductIdentity
    {
    }
}
