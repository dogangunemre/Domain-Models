using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Brands.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Brands.Objects
{
    public class BrandItemList<T> : Lista<T>, IBrandItemList<T>
        where T : IBrandIdentity
    {
    }
}
