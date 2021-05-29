using Ohtap.ECommerce.Domain.Models.Objects.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.PromotionDetails
{
    public class PromotionDetail : PromotionDetailBasic, IPromotionDetail
    {
        ILanguage IPromotionDetail.Language { get; set; }
    }
}
