using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Products
{
    public interface IProductList<T> : IProductDataList<T>
        where T : IProductData
    {
    }
}
