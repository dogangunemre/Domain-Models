﻿using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Addresses.Interfaces;
using Ohtap.ECommerce.Domain.Models.Objects.Regions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Addresses.Objects
{
    public class AddressBasic : AddressInfo, IAddressBasic
    {
        private int _Order;
        public virtual int Order { get => base.GetProperty(this._Order); set => base.SetProperty(ref this._Order, value); }

        private string _Description;
        public virtual string Description { get => base.GetProperty(this._Description); set => base.SetProperty(ref this._Description, value); }

        private int _State;
        public virtual int State { get => base.GetProperty(this._State); set => base.SetProperty(ref this._State, value); }

        private string _FullAddress;
        public virtual string FullAddress { get => base.GetProperty(this._FullAddress); set => base.SetProperty(ref this._FullAddress, value); }

        private string _PostCode;
        public virtual string PostCode { get => base.GetProperty(this._PostCode); set => base.SetProperty(ref this._PostCode, value); }


        private RegionBasic _Region;
        public virtual RegionBasic Region { get => GetProperty(this._Region); set => base.SetProperty(ref this._Region, value); }
        RegionBasic IAddressBasic.Region { get { return this.Region as RegionBasic; } set { this.Region = (Region)value; } }



    }
}
