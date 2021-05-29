using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Languages;
using Ohtap.ECommerce.Domain.Models.Objects.VariationDetails;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.VariationDetails
{
    public class VariationDetail : VariationDetailBasic, IVariationDetail
    {
        ILanguage IVariationDetail.Language { get; set; }
    }
}
