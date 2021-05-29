using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Currencies
{
    [DataContract]
    [Serializable]
    public class CurrencyBasicFilter : CurrencyBasic, ICurrencyBasicFilter
    {
    }
}
