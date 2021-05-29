using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Relations.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Relations.Objects
{
    public class RelationItemList<T> : Lista<T>, IRelationItemList<T>
        where T : IRelationIdentity
    {
    }
}
