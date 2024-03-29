﻿using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.ProductStatuses.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductStatuses.Objects
{
    public class ProductStatusItemList<T> : Lista<T>, IProductStatusItemList<T>
        where T : IProductStatusIdentity
    {
    }
}
