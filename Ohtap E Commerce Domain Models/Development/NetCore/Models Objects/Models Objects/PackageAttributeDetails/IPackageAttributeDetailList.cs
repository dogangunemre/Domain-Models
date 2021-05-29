using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.PackageAttributeDetails
{
    public interface IPackageAttributeDetailList <T>: IPackageAttributeDetailDataList<T>
        where T : IPackageAttributeDetailData
    {
    }
}
