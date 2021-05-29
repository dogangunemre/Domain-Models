using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Attributes;
using Ohtap.ECommerce.Domain.Models.Serializable.Objects.LanguageDetails;
using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Prices;
using Ohtap.ECommerce.Domain.Models.Serializable.Objects.ProductDetails;
using Ohtap.ECommerce.Domain.Models.Serializable.Objects.ProductLabels;
using Ohtap.ECommerce.Domain.Models.Serializable.Objects.ProductOptions;
using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Taxes;
using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Warehouses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Attributes;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ECommerce.Domain.Models.Objects.Categories;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;
using Ohtap.ECommerce.Domain.Models.Objects.Feedbacks;
using Ohtap.ECommerce.Domain.Models.Objects.Files;
using Ohtap.ECommerce.Domain.Models.Objects.Manifacturers;
using Ohtap.ECommerce.Domain.Models.Objects.Measures;
using Ohtap.ECommerce.Domain.Models.Objects.Prices;
using Ohtap.ECommerce.Domain.Models.Objects.ProductDetails;
using Ohtap.ECommerce.Domain.Models.Objects.ProductLabels;
using Ohtap.ECommerce.Domain.Models.Objects.ProductOptions;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.ProductSpecifications;
using Ohtap.ECommerce.Domain.Models.Objects.Taxes;
using Ohtap.ECommerce.Domain.Models.Objects.Warehouses;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Products
{
    public class Product : ProductBasic, IProduct
    {
        public IFileDataList Photos { set; get; }
        public IDiscountData Discount { set; get; }
        public ICategoryDataList Categories { set; get; }
        public IManifacturerData Manifacturer { set; get; }
        public IFeedbackDataList Feedbacks { set; get; }
        public IBrandData Brand { set; get; }
        public IMeasureDataList Measures { set; get; }

        public IProductDetailDataList Details { set; get; }
        public ITaxData Tax { set; get; }
        public IPriceDataList Prices { set; get; }
        public IWarehouseDataList Warehouses { set; get; }
        public IProductOptionDataList Options { set; get; }
        public IProductLabelDataList Labels { set; get; }
        public IProductSpecificationDataList Specifications { set; get; }
        public IAttributeDataList Attributes { set; get; }
    }
}
