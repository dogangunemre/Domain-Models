using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.PackageAttributes
{
    public interface IPackageAttribute : IPackageAttributeData
    {
        PackageDetails.IPackageDetailDataList Details { set; get; }
      
    }
}
