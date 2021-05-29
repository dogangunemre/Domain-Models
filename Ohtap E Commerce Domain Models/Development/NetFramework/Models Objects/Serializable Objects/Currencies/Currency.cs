using Ohtap.ECommerce.Domain.Models.Serializable.Objects.CurrencyDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using Ohtap.ECommerce.Domain.Models.Objects.CurrencyDetails;
using System.Runtime.Serialization;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Currencies
{
    [DataContract]
    [Serializable]
    public class Currency : CurrencyBasic, ICurrency
    {

        [DataMember]
        public CurrencyDetails. CurrencyDetailList Details { get; set; }




        ICurrencyDetailDataList ICurrency.Details { get { return this.Details; } set { this.Details = (CurrencyDetails.CurrencyDetailList)value; } }
    }
}
