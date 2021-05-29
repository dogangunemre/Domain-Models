using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.Languages
{
    public class LanguageBasic : ILanguageData
    {
        public virtual string ID { set; get; }
        public virtual string Code { set; get; }
        public virtual string Name { set; get; }
        public virtual int Order { set; get; }
        public virtual string Description { set; get; }
        public virtual int State { set; get; }
    }
}
