using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.PackageOptions
{
    public interface IPackageOptionData :  CoreObject.IObjectID, CoreObject.IObjectCode, CoreObject.IObjectOrder, CoreObject.IObjectDescription, CoreObject.IObjectState, IPackageOptionValue, IPackageOptionOption
    {

    }
}
