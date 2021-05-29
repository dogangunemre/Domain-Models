﻿using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.PackageOptions.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.PackageOptions.Objects
{
    public class PackageOptionItemList<T> : Lista<T>, IPackageOptionItemList<T>
        where T : IPackageOptionIdentity
    {
    }
}
