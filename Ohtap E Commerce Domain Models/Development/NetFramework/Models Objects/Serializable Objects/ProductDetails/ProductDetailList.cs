using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.ProductDetails;
using CoreSystem = Ohtap.ECommerce.Domain.Models.Core.System;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.ProductDetails
{
    public class ProductDetailList : CoreSystem.Lista<IProductDetailData>, IProductDetailList
    {
    }
}
