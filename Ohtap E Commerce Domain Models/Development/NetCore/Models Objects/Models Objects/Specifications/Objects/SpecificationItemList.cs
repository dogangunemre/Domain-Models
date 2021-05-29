using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Specifications.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Specifications.Objects
{
    public class SpecificationItemList<T> : Lista<T>, ISpecificationItemList<T>
        where T : ISpecificationIdentity
    {
    }
}
