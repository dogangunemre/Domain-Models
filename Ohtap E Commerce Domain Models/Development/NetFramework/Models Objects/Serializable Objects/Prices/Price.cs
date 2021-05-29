using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using Ohtap.ECommerce.Domain.Models.Objects.Prices;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Prices
{
    public class Price : PriceBasic, IPrice
    {
        public ICurrencyDataList Currencies { set; get; }
    }
}
