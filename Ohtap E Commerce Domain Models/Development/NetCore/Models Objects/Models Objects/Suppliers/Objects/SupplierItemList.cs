using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Suppliers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Suppliers.Objects
{
    public class SupplierItemList<T> : Lista<T>, ISupplierItemList<T>
        where T : ISupplierIdentity
    {
    }
}
