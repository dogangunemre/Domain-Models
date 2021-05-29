using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.PackageAttributes;
using CoreSystem = Ohtap.ECommerce.Domain.Models.Core.System;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.PackageAttributes
{
    public class PackageAttributeList : CoreSystem.Lista<IPackageAttributeData>, IPackageAttributeList
    {
    }
}