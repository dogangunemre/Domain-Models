﻿using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Packages.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Packages.Objects
{
    public class PackageItemList<T> : Lista<T>, IPackageItemList<T>
        where T : IPackageIdentity
    {
    }
}
