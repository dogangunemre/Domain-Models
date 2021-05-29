using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.PackageLabels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.PackageLabels.Objects
{
    public class PackageLabelItemList<T> : Lista<T>, IPackageLabelItemList<T>
        where T : IPackageLabelIdentity
    {
    }
}
