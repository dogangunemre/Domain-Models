﻿using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Stores.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Stores.Objects
{
    public class StoreItemList<T> : Lista<T>, IStoreItemList<T>
        where T : IStoreIdentity
    {
    }
}