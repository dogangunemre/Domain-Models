﻿using Ohtap.ECommerce.Domain.Models.Objects.ProductAttributes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductAttributes.Objects
{
    public class ProductAttributeInfoFilter : ProductAttributeIdentityFilter, IProductAttributeInfoFilter
    {
        private string _Code;
        public virtual string Code { get => base.GetProperty(this._Code); set => base.SetProperty(ref this._Code, value); }

        private string _Name;
        public virtual string Name { get => base.GetProperty(this._Name); set => base.SetProperty(ref this._Name, value); }
    }
}