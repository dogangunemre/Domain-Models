using Ohtap.ECommerce.Domain.Models.Objects.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Currencies
{
    public class CurrencyBasic : ICurrencyData
    {
        public virtual string ID { get; set; }
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual int Order { get; set; }
        public virtual string Description { get; set; }
        public virtual int State { get; set; }
        public virtual Units.UnitBasic Unit { get; set; }
        public virtual string Symbol { get; set; }
        public virtual string FundCode { get; set; }

        IUnitData ICurrenciesUnit.Unit { get { return this.Unit; } set { this.Unit = (Units.Unit)value; } }
    }
}
