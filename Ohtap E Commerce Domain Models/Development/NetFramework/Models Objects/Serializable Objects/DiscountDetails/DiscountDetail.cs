using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.DiscountDetails;
using Ohtap.ECommerce.Domain.Models.Objects.Languages;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.DiscountDetails
{
    public class DiscountDetail : DiscountDetailBasic, IDiscountDetail
    {
        ILanguage IDiscountDetail.Language { get; set; }
    }
}
