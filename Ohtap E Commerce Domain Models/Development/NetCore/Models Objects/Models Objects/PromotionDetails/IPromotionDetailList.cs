using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.PromotionDetails
{
    public interface IPromotionDetailList<T> : IPromotionDetailDataList<T>
        where T: IPromotionDetailData
    {
    }
}
