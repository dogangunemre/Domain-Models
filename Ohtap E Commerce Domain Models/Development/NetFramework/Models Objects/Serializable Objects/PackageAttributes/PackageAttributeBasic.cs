using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Attributes;
using Ohtap.ECommerce.Domain.Models.Objects.PackageAttributes;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.PackageAttributes
{
    public class PackageAttributeBasic : IPackageAttributeData
    {
        public string ID { get; set; }
        
        public int Order { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public string Value { get; set; }
        public IAttributeData Attribute { get; set; }
    }
}
