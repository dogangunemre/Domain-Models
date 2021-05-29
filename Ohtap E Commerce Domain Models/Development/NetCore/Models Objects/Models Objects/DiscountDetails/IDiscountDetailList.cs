using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.DiscountDetails
{
    public interface IDiscountDetailList<T> : IDiscountDetailDataList<T>
        where T: IDiscountDetailData
    {
    }
}
