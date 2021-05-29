using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Languages
{
    public class LanguageBasic : ILanguageData
    {
        public string ID { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public string LanguageCode { set; get; }
        public int Order { set; get; }
        public string Description { set; get; }
        public int State { set; get; }
    }
}
