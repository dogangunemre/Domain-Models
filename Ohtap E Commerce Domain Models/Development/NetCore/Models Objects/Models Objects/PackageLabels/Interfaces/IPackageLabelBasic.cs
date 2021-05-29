﻿using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.PackageLabels.Interfaces
{
    public interface IPackageLabelBasic : IObjectBasic, IPackageLabelInfo
    {
        string Symbol { get; set; }
        string FundCode { get; set; }
    }
}
