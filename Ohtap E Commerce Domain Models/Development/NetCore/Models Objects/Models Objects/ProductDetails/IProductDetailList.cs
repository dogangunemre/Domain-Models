using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductDetails
{
    public interface IProductDetailList<T> : IProductDetailDataList<T>
        where T : IProductDetailData
    {
    }
}
