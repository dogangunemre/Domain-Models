using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Cargos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Cargos.Objects
{
    public class CargoBasic : CargoInfo, ICargoBasic
    {
        private int _Order;
        public virtual int Order { get => base.GetProperty(this._Order); set => base.SetProperty(ref this._Order, value); }

        private string _Description;
        public virtual string Description { get => base.GetProperty(this._Description); set => base.SetProperty(ref this._Description, value); }

        private int _State;
        public virtual int State { get => base.GetProperty(this._State); set => base.SetProperty(ref this._State, value); }

        private int _ID;
        public virtual int ID { get => base.GetProperty(this._ID); set => base.SetProperty(ref this._ID, value); }

        private string _EMail;
        public virtual string EMail { get => base.GetProperty(this._EMail); set => base.SetProperty(ref this._EMail, value); }

        private string _Fax;
        public virtual string Fax { get => base.GetProperty(this._Fax); set => base.SetProperty(ref this._Fax, value); }

        private string _Phone;
        public virtual string Phone { get => base.GetProperty(this._Phone); set => base.SetProperty(ref this._Phone, value); }
    }
}
