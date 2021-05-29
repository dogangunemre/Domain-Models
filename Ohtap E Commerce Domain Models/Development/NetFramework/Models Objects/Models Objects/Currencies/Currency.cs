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
    public class Currency : CurrencyBasic, ICurrency
    {
        public virtual CurrencyDetailDataList Details { get; set; }

        ICurrencyDetailList ICurrency.Details { get { return this.Details as ICurrencyDetailList; } set { this.Details = value; } }
    }
}
