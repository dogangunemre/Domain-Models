using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Taxes.Interfaces;
using Ohtap.ECommerce.Domain.Models.Objects.Regions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Taxes.Objects
{
    public class TaxBasic : TaxInfo, ITaxBasic
    {
        private int _Order;
        public virtual int Order { get => base.GetProperty(this._Order); set => base.SetProperty(ref this._Order, value); }

        private string _Description;
        public virtual string Description { get => base.GetProperty(this._Description); set => base.SetProperty(ref this._Description, value); }

        private int _State;
        public virtual int State { get => base.GetProperty(this._State); set => base.SetProperty(ref this._State, value); }

        private decimal _Value;
        public virtual decimal Value { get => base.GetProperty(this._Value); set => base.SetProperty(ref this._Value, value); }

        private RegionBasic _Region;
        public virtual RegionBasic Region { get => GetProperty(this._Region); set => base.SetProperty(ref this._Region, value); }
        RegionBasic ITaxBasic.Region { get { return this.Region as RegionBasic; } set { this.Region = (Region)value; } }
    }
}
