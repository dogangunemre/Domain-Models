using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductAttributes
{
    public interface IProductAttributeList<T> : IProductAttributeDataList<T>
        where T : IProductAttributeData
    {
    }
}
