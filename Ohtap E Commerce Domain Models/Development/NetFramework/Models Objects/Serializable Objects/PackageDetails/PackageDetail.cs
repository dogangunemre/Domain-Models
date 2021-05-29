using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Languages;
using Ohtap.ECommerce.Domain.Models.Objects.PackageDetails;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.PackageDetails
{
    public class PackageDetail : PackageDetailBasic, IPackageDetail
    {
        ILanguage IPackageDetail.Language { get; set; }
    }
}
