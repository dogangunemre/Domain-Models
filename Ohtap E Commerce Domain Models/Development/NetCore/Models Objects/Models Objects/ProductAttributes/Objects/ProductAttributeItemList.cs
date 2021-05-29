﻿using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.ProductAttributes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductAttributes.Objects
{
    public class ProductAttributeItemList<T> : Lista<T>, IProductAttributeItemList<T>
        where T : IProductAttributeIdentity
    {
    }
}