﻿using System;
using System.Collections.Generic;
using System.Text;
using Ohtap.ECommerce.Domain.Models.Objects.Files;

namespace Ohtap.ECommerce.Domain.Models.Objects.Brands.Objects
{
    public class BrandBasicFilter : BrandInfoFilter, Interfaces.IBrandBasicFilter
    {
        private int _Order;
        public virtual int Order { get => base.GetProperty(this._Order); set => base.SetProperty(ref this._Order, value); }

        private string _Description;
        public virtual string Description { get => base.GetProperty(this._Description); set => base.SetProperty(ref this._Description, value); }

        private int _State;
        public virtual int State { get => base.GetProperty(this._State); set => base.SetProperty(ref this._State, value); }

        private File _Logo;
        public virtual File Logo { get => base.GetProperty(this._Logo); set => base.SetProperty(ref this._Logo, value); }
    }
}
