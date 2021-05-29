using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.PackageLabels
{
    public interface IPackageLabelList<T> : IPackageLabelDataList<T>
        where T : IPackageLabelData
    {
    }
}
