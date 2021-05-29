using Ohtap.ECommerce.Domain.Models.Objects.DiscountDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Discounts
{
    public interface IDiscount : IDiscountData
    {
        IDiscountDetailDataList<IDiscountDetailData> Details { set; get; }
      
    }
}
