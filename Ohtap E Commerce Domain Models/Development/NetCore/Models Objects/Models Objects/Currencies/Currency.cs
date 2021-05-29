using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.CurrencyDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;

namespace Ohtap.ECommerce.Domain.Models.Objects.Currencies
{
    public class Currency : CurrencyBasic, ICurrencyDetail
    {
        private CurrencyDetailList _Details;
        public virtual CurrencyDetailList Details { get => base.GetProperty(this._Details); set => base.SetProperty(ref this._Details, value); }

        ICurrencyDetailList<ICurrencyDetailData> ICurrencyDetail.Details { get { return this.Details as ICurrencyDetailList<ICurrencyDetailData>; } set { this.Details = (CurrencyDetailList)value; } }
    }
}
