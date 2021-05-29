using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Languages;
using Ohtap.ECommerce.Domain.Models.Objects.RegionDetails;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.RegionDetails
{
    public class RegionDetail : RegionDetailBasic, IRegionDetail
    {
        ILanguage IRegionDetail.Language { get; set; }
    }
}
