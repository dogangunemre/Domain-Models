using Ohtap.ECommerce.Domain.Models.Objects.PackageAttributeDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.PackageAttributes
{
    public interface IPackageAttribute : IPackageAttributeData
    {
        IPackageAttributeDetailDataList<IPackageAttributeDetailData> Details { set; get; }
      
    }
}
