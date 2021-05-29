using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.ProductPackageAttributes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductPackageAttributes.Objects
{
    public class ProductPackageAttributeItemList<T> : Lista<T>, IProductPackageAttributeItemList<T>
        where T : IProductPackageAttributeIdentity
    {
    }
}
