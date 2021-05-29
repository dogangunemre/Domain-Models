using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Prices
{
    public class Price : PriceBasic, IPrice
    {
        private Currency _Currency;
        public virtual Currency Currency { get => base.GetProperty(this._Currency); set => base.SetProperty(ref this._Currency, value); }
        ICurrencyData IPrice.Currency { get { return this.Currency as ICurrencyData; } set { this.Currency = (Currency)value; } }
    }
}
