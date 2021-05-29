using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.ProductLabels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductLabels.Objects
{
    public class ProductLabelItemList<T> : Lista<T>, IProductLabelItemList<T>
        where T : IProductLabelIdentity
    {
    }
}
