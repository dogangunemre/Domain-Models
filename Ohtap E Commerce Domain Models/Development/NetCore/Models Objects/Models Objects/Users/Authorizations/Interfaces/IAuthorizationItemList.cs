﻿using Ohtap.ECommerce.Domain.Models.Core.Object;
using Ohtap.ECommerce.Domain.Models.Core.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Authorizations.Interfaces
{
    public interface IAuthorizationItemList<T> : ILista<T>
        where T: IAuthorizationIdentity
    {
    }
}
