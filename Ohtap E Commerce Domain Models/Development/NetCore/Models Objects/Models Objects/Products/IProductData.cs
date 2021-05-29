using Ohtap.ECommerce.Domain.Models.Objects.Attributes;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Objects.Files;
using Ohtap.ECommerce.Domain.Models.Objects.Labels;
using Ohtap.ECommerce.Domain.Models.Objects.Manufacturers;
using Ohtap.ECommerce.Domain.Models.Objects.Measures;
using Ohtap.ECommerce.Domain.Models.Objects.Options;
using Ohtap.ECommerce.Domain.Models.Objects.Prices;
using Ohtap.ECommerce.Domain.Models.Objects.ProductCategories;
using Ohtap.ECommerce.Domain.Models.Objects.ProductDetails;
using Ohtap.ECommerce.Domain.Models.Objects.ProductGroups;
using Ohtap.ECommerce.Domain.Models.Objects.Settings;
using Ohtap.ECommerce.Domain.Models.Objects.Suppliers;
using Ohtap.ECommerce.Domain.Models.Objects.Taxes;
using Ohtap.ECommerce.Domain.Models.Objects.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.Products
{
    public interface IProductData : CoreObject.IObjectID, CoreObject.IObjectCode, CoreObject.IObjectName, CoreObject.IObjectOrder, CoreObject.IObjectDescription, CoreObject.IObjectState, IProductSKU, IProductBarcode
    {

        public BrandBasic Brand { get; set; }
        public ManufacturerBasic Manufacturer { get; set; }
        public SupplierBasic Supplier { get; set; }
        public ProductDetailBasic Detail { get; set; }
        public List<ProductCategoryBasic> Categories { get; set; }
        public List<ProductGroupBasic> Groups { get; set; }
        public List<FileBasic> Photos { get; set; }
        public UnitBasic Unit { get; set; }
        public MeasureBasic Measure  { get; set; }
        public List<PriceBasic> Prices  { get; set; }
        public List<AttributeBasic> Attributes { get; set; }
        public TaxBasic Tax { get; set; }
        public List<LabelBasic> Labels { get; set; }
        public List<OptionBasic> Options { get; set; }
        public List<SettingBasic> Settings { get; set; }
        public List<ProductStockBasic> Stocks { get; set; }
        IDataItemList<IDataItemData> Dataset { get; set; }

    }
}
