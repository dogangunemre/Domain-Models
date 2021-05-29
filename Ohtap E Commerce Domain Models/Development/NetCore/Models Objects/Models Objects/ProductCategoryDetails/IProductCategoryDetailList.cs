using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductCategoryDetails
{
    public interface IProductCategoryDetailList<T> : IProductCategoryDetailDataList<T>
        where T : IProductCategoryDetailData
    {
    }
}
