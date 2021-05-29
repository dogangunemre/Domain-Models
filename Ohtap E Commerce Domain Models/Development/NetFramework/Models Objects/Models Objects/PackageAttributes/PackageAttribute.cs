using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.PackageDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.PackageAttributes
{
    public class PackageAttribute : PackageAttributeBasic, IPackageAttribute
    {
        
        IPackageDetailDataList IPackageAttribute.Details { get; set; }
    }
}
