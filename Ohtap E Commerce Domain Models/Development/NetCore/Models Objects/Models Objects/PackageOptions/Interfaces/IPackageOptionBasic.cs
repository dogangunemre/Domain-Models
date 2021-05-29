using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.PackageOptions.Interfaces
{
    public interface IPackageOptionBasic : IObjectBasic, IPackageOptionInfo
    {
        string Symbol { get; set; }
        string FundCode { get; set; }
    }
}
