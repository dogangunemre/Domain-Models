using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.CouponDetails;
using CoreSystem = Ohtap.ECommerce.Domain.Models.Core.System;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.CouponDetails
{
    public class CouponDetailList : CoreSystem.Lista<ICouponDetailData>, ICouponDetailList
    {
    }
}
