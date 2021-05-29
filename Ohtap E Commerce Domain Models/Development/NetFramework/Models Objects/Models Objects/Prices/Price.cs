using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Prices
{
    public class Price : PriceBasic, IPrice
    {
        public Currencies.CurrencyList Currencies { set; get; }
    }
}
