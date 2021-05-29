using Ohtap.ECommerce.Domain.Models.Core.Object;
using Ohtap.ECommerce.Domain.Models.Core.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductGroups.Interfaces
{
    public interface IProductGroupItemList<T> : ILista<T>
        where T: IProductGroupIdentity
    {
    }
}
