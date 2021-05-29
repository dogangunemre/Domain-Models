using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Measures.Objects
{
    public class MeasureBasicFilter : MeasureInfoFilter, Interfaces.IMeasureBasicFilter
    {
        private int _Order;
        public virtual int Order { get => base.GetProperty(this._Order); set => base.SetProperty(ref this._Order, value); }

        private string _Description;
        public virtual string Description { get => base.GetProperty(this._Description); set => base.SetProperty(ref this._Description, value); }

        private int _State;
        public virtual int State { get => base.GetProperty(this._State); set => base.SetProperty(ref this._State, value); }

        private string _Symbol;
        public virtual string Symbol { get => base.GetProperty(this._Symbol); set => base.SetProperty(ref this._Symbol, value); }

        private string _FundCode;
        public virtual string FundCode { get => base.GetProperty(this._FundCode); set => base.SetProperty(ref this._FundCode, value); }
    }
}
