using Ohtap.ECommerce.Domain.Models.Objects.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.CouponDetails
{
    public class CouponDetail : CouponDetailBasic, ICouponDetail
    {
        ILanguage ICouponDetail.Language { get; set; }
    }
}
