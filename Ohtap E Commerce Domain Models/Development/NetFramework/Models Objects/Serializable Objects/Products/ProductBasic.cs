using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Products;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Products
{
    public class ProductBasic : IProductData
    {
        public string ID { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public string LanguageCode { set; get; }
        public int Order { set; get; }
        public string Description { set; get; }
        public int State { set; get; }
        public string SKU { set; get; }
        public string Barcode { set; get; }
    }
}
