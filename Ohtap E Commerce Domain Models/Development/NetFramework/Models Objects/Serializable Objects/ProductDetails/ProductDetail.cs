using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Languages;
using Ohtap.ECommerce.Domain.Models.Objects.ProductDetails;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.ProductDetails
{
    public class ProductDetail : ProductDetailBasic, IProductDetail
    {
        ILanguage IProductDetail.Language { get; set; }
    }
}
