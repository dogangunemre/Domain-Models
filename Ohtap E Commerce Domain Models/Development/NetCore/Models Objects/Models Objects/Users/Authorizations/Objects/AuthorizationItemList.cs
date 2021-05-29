using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Authorizations.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Authorizations.Objects
{
    public class AuthorizationItemList<T> : Lista<T>, IAuthorizationItemList<T>
        where T : IAuthorizationIdentity
    {
    }
}
