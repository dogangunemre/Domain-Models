using Ohtap.ECommerce.Domain.Models.Core.Object;
using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Manufacturers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Manufacturers.Objects
{
    public class Manufacturer : ManufacturerBasic, Interfaces.IManufacturer
    {
        private DataSetList _DataSet;
        public virtual DataSetList DataSet { get => base.GetProperty(this._DataSet); set => base.SetProperty(ref this._DataSet, value); }
        IDataSetList IObject.DataSet { get => this.DataSet as IDataSetList; set => this.DataSet = (DataSetList)value; }


        private LocalizationList<ManufacturerBasic> _Localizations;
        public virtual LocalizationList<ManufacturerBasic> Localizations { get => base.GetProperty(this._Localizations); set => base.SetProperty(ref this._Localizations, value); }
        ILocalizationList<IObjectBasic> IObject.Localizations { get => this.Localizations as ILocalizationList<IObjectBasic>; set => this.Localizations = (LocalizationList<ManufacturerBasic>)value; }
    }
}
