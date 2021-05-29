using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using Ohtap.ECommerce.Domain.Models.Objects.Units;
using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Currencies
{
    [DataContract]
    [Serializable]
    public class CurrencyBasic : ICurrencyData
    {
        [DataMember]
        public string ID { get; set; }
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Order { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int State { get; set; }
        [DataMember]
        public Units.UnitBasic Unit { get; set; }
        [DataMember]
        public string Symbol { get; set; }
        [DataMember]
        public string FundCode { get; set; }




        IUnitData ICurrenciesUnit.Unit { get { return this.Unit; } set { this.Unit = (Units.UnitBasic)value; } }
    }
}
