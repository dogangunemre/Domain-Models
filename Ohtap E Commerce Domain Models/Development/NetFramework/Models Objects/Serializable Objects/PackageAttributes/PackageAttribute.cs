using Ohtap.ECommerce.Domain.Models.Serializable.Objects.PackageDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.PackageAttributes;
using Ohtap.ECommerce.Domain.Models.Objects.PackageDetails;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.PackageAttributes
{
    public class PackageAttribute : PackageAttributeBasic, IPackageAttribute
    {
        
        IPackageDetailDataList IPackageAttribute.Details { get; set; }
    }
}
