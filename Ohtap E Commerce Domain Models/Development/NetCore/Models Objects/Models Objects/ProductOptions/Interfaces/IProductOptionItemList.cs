﻿using Ohtap.ECommerce.Domain.Models.Core.Object;
using Ohtap.ECommerce.Domain.Models.Core.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductOptions.Interfaces
{
    public interface IProductOptionItemList<T> : ILista<T>
        where T: IProductOptionIdentity
    {
    }
}
