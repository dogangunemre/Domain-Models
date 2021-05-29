using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.PackageOptions
{
    public interface IPackageOptionList<T> : IPackageOptionDataList<T>
        where T : IPackageOptionData
    {
    }
}
