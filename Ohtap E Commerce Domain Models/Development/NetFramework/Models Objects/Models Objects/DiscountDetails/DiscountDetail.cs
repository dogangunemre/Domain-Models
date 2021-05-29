using Ohtap.ECommerce.Domain.Models.Objects.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.DiscountDetails
{
    public class DiscountDetail : DiscountDetailBasic, IDiscountDetail
    {
         ILanguage IDiscountDetail.Language { get; set; }
    }
}
