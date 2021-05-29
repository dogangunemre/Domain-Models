using Ohtap.ECommerce.Domain.Models.Objects.CurrencyDetails;
using Ohtap.ECommerce.Domain.Models.Objects.LanguageDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Languages
{
    public class Language : ILanguageData, ILanguage
    {
        public virtual CurrencyDetailDataList Details { get; set; }
        public virtual string ID { get; set; }
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual int Order { get; set; }
        public virtual string Description { get; set; }
        public virtual int State { get; set; }
    }
}
