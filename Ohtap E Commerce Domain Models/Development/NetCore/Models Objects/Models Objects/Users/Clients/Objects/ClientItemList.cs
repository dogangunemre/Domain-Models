using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Clients.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Clients.Objects
{
    public class ClientItemList<T> : Lista<T>, IClientItemList<T>
        where T : IClientIdentity
    {
    }
}
