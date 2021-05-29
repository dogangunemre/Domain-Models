using Ohtap.ECommerce.Domain.Models.Core.Object;
using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Coupons.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Coupons.Objects
{
    public class Coupon : CouponBasic, Interfaces.ICoupon
    {
        private DataSetList _DataSet;
        public virtual DataSetList DataSet { get => base.GetProperty(this._DataSet); set => base.SetProperty(ref this._DataSet, value); }
        IDataSetList IObject.DataSet { get => this.DataSet as IDataSetList; set => this.DataSet = (DataSetList)value; }


        private LocalizationList<CouponBasic> _Localizations;
        public virtual LocalizationList<CouponBasic> Localizations { get => base.GetProperty(this._Localizations); set => base.SetProperty(ref this._Localizations, value); }
        ILocalizationList<IObjectBasic> IObject.Localizations { get => this.Localizations as ILocalizationList<IObjectBasic>; set => this.Localizations = (LocalizationList<CouponBasic>)value; }
    }
}
