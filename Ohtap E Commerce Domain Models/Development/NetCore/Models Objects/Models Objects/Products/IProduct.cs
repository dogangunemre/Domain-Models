using Ohtap.ECommerce.Domain.Models.Objects.Attributes;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;
using Ohtap.ECommerce.Domain.Models.Objects.Feedbacks;
using Ohtap.ECommerce.Domain.Models.Objects.Files;
using Ohtap.ECommerce.Domain.Models.Objects.Labels;
using Ohtap.ECommerce.Domain.Models.Objects.Manufacturers;
using Ohtap.ECommerce.Domain.Models.Objects.Measures;
using Ohtap.ECommerce.Domain.Models.Objects.Options;
using Ohtap.ECommerce.Domain.Models.Objects.ProductDetails;
using Ohtap.ECommerce.Domain.Models.Objects.Prices;
using Ohtap.ECommerce.Domain.Models.Objects.ProductCategories;
using Ohtap.ECommerce.Domain.Models.Objects.Specifications;
using Ohtap.ECommerce.Domain.Models.Objects.Taxes;
using Ohtap.ECommerce.Domain.Models.Objects.Warehouses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Products
{
    public interface IProduct : IProductData
    {
        IProductCategoryDataList<IProductCategoryData> Categories { get; set; }
        IFileDataList<IFileData> Photos { get; set; }
        IBrandData Brand { get; set; }
        IManufacturerData Manufacturer { get; set; }
        ITaxData Tax { get; set; }
        IMeasureDataList<IMeasureData> Measures { get; set; }
        IPriceDataList<IPriceData> Prices { get; set; }
        IOptionDataList<IOptionData> Options { get; set; }
        ILabelDataList<ILabelData> Labels { get; set; }
        IFeedbackDataList<IFeedbackData> Feedbacks { get; set; }
        IAttributeDataList<IAttributeData> Attributes { get; set; }
        IDiscountDataList<IDiscountData> Discounts { get; set; }
        IWarehouseDataList<IWarehouseData> Warehouses { get; set; }
        ISpecificationDataList<ISpecificationData> Specifications { get; set; }

        IProductDetailDataList<IProductDetailData> Details { set; get; }
    }
}
