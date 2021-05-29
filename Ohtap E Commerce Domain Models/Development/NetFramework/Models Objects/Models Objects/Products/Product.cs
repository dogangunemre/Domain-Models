using Ohtap.ECommerce.Domain.Models.Objects.Attributes;
using Ohtap.ECommerce.Domain.Models.Objects.LanguageDetails;
using Ohtap.ECommerce.Domain.Models.Objects.Prices;
using Ohtap.ECommerce.Domain.Models.Objects.ProductDetails;
using Ohtap.ECommerce.Domain.Models.Objects.ProductLabels;
using Ohtap.ECommerce.Domain.Models.Objects.ProductOptions;
using Ohtap.ECommerce.Domain.Models.Objects.Taxes;
using Ohtap.ECommerce.Domain.Models.Objects.Warehouses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Products
{
    public class Product : ProductBasic, IProduct
    {
        public virtual Files.IFileDataList Photos { set; get; }
        public virtual Discounts.IDiscountData Discount { set; get; }
        public virtual Categories.ICategoryDataList Categories { set; get; }
        public virtual Manufacturers.IManufacturerData Manufacturer { set; get; }
        public virtual Feedbacks.IFeedbackDataList Feedbacks { set; get; }
        public virtual Brands.IBrandData Brand { set; get; }
        public virtual Measures.IMeasureDataList Measures { set; get; }
        public virtual IProductDetailDataList Details { set; get; }
        public virtual ITaxData Tax { set; get; }
        public virtual IPriceDataList Prices { set; get; }
        public virtual IWarehouseDataList Warehouses { set; get; }
        public virtual IProductOptionDataList Options { set; get; }
        public virtual IProductLabelDataList Labels { set; get; }
        public virtual ProductSpecifications.IProductSpecificationDataList Specifications { set; get; }
        public virtual IAttributeDataList Attributes { set; get; }
    }
}
