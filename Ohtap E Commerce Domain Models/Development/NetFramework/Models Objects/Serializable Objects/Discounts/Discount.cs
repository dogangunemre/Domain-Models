using Ohtap.ECommerce.Domain.Models.Serializable.Objects.DiscountDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.DiscountDetails;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Discounts
{
    public class Discount : DiscountBasic, IDiscount
    {
        
        IDiscountDetailDataList IDiscount.Details { get; set; }
    }
}
