using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductCategories
{
    public interface IProductCategoryList<T> : IProductCategoryDataList<T>
        where T : IProductCategoryData
    {
    }
}
