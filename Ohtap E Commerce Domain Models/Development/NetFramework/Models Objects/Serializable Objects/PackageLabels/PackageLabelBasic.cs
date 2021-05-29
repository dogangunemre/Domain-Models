using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Labels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Labels;
using Ohtap.ECommerce.Domain.Models.Objects.PackageLabels;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.PackageLabels
{
    public class PackageLabelBasic : IPackageLabelData
    {
        public string ID { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public string Value { get; set; }
        public ILabelData Label { get; set; }
    }
}
