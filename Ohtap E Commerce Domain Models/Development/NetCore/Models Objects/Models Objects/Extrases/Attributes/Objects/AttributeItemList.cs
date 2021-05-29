using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Attributes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Attributes.Objects
{
    public class AttributeItemList<T> : Lista<T>, IAttributeItemList<T>
        where T : IAttributeIdentity
    {
    }
}
