using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Products
{
    public interface IProduct : IProductData
    {
        Discounts.IDiscountData Discount { get; set; }
        Taxes.ITaxData Tax { get; set; }
        Files.IFileDataList Photos { get; set; }
        Categories.ICategoryDataList Categories { get; set; }
        Manufacturers.IManufacturerData Manufacturer { get; set; }
        Feedbacks.IFeedbackDataList Feedbacks { get; set; }
        Brands.IBrandData Brand { get; set; }
        Prices.IPriceDataList Prices { get; set; }
        Measures.IMeasureDataList Measures { get; set; }
        ProductDetails.IProductDetailDataList Details { set; get; }
        Warehouses.IWarehouseDataList Warehouses { get; set; }
        ProductOptions.IProductOptionDataList Options { get; set; }
        ProductLabels.IProductLabelDataList Labels { get; set; }
        ProductSpecifications.IProductSpecificationDataList Specifications { get; set; }
        Attributes.IAttributeDataList Attributes { get; set; }
    }
}
