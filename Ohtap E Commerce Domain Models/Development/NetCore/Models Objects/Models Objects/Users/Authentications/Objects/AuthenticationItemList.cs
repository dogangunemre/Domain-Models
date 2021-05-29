using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Authentications.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Authentications.Objects
{
    public class AuthenticationItemList<T> : Lista<T>, IAuthenticationItemList<T>
        where T : IAuthenticationIdentity
    {
    }
}
