using Ohtap.ECommerce.Domain.Models.Core.Object;
using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Addresses;
using Ohtap.ECommerce.Domain.Models.Objects.Addresses.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Banks.Objects
{
    public class Bank : BankBasic, Interfaces.IBank
    {
        private DataSetList _DataSet;
        public virtual DataSetList DataSet { get => base.GetProperty(this._DataSet); set => base.SetProperty(ref this._DataSet, value); }
        IDataSetList IObject.DataSet { get => this.DataSet as IDataSetList; set => this.DataSet = (DataSetList)value; }


        private LocalizationList<BankBasic> _Localizations;
        public virtual LocalizationList<BankBasic> Localizations { get => base.GetProperty(this._Localizations); set => base.SetProperty(ref this._Localizations, value); }
        ILocalizationList<IObjectBasic> IObject.Localizations { get => this.Localizations as ILocalizationList<IObjectBasic>; set => this.Localizations = (LocalizationList<BankBasic>)value; }
        
        private Address _Address;
        public virtual Address Address { get => base.GetProperty(this._Address); set => base.SetProperty(ref this._Address, value); }
        IAddressBasic Interfaces.IBank.Address { get { return this.Address as IAddressBasic; } set { this.Address = (Address)value; } }
    }
}
