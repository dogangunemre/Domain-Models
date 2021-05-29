using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Products
{
    public class ProductBasic : IProductData
    {
        public virtual string ID { set; get; }
        public virtual string Code { set; get; }
        public virtual string Name { set; get; }
        public virtual string LanguageCode { set; get; }
        public virtual int Order { set; get; }
        public virtual string Description { set; get; }
        public virtual int State { set; get; }
        public virtual string SKU { set; get; }
        public virtual string Barcode { set; get; }
    }
}
