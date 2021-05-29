using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Core.System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ECommerce.Domain.Models.Objects.Manufacturers;
using Ohtap.ECommerce.Domain.Models.Objects.Suppliers;
using Ohtap.ECommerce.Domain.Models.Objects.ProductGroups;
using Ohtap.ECommerce.Domain.Models.Objects.Files;
using Ohtap.ECommerce.Domain.Models.Objects.Units;
using Ohtap.ECommerce.Domain.Models.Objects.Prices;
using Ohtap.ECommerce.Domain.Models.Objects.Attributes;
using Ohtap.ECommerce.Domain.Models.Objects.Taxes;
using Ohtap.ECommerce.Domain.Models.Objects.Labels;
using Ohtap.ECommerce.Domain.Models.Objects.Options;
using Ohtap.ECommerce.Domain.Models.Objects.Settings;
using Ohtap.ECommerce.Domain.Models.Objects.Measures;
using Ohtap.ECommerce.Domain.Models.Objects.ProductDetails;
using Ohtap.ECommerce.Domain.Models.Objects.ProductCategories;
using Ohtap.ECommerce.Domain.Models.Objects.ProductStatuses;

namespace Ohtap.ECommerce.Domain.Models.Objects.Products
{
    public class ProductBasic :Objecta, IProductData
    {
        private string _ID;
        public virtual string ID { get => base.GetProperty(this._ID); set => base.SetProperty(ref this._ID, value); }

        private string _Code;
        public virtual string Code { get => base.GetProperty(this._Code); set => base.SetProperty(ref this._Code, value); }

        private string _Name;
        public virtual string Name { get => base.GetProperty(this._Name); set => base.SetProperty(ref this._Name, value); }

        private int _Order;
        public virtual int Order { get => base.GetProperty(this._Order); set => base.SetProperty(ref this._Order, value); }

        private string _Description;
        public virtual string Description { get => base.GetProperty(this._Description); set => base.SetProperty(ref this._Description, value); }

        private int _State;
        public virtual int State { get => base.GetProperty(this._State); set => base.SetProperty(ref this._State, value); }


        private string _SKU;
        public virtual string SKU { get => base.GetProperty(this._SKU); set => base.SetProperty(ref this._SKU, value); }


        private string _Barcode;
        public virtual string Barcode { get => base.GetProperty(this._Barcode); set => base.SetProperty(ref this._Barcode, value); }
       
        private ProductDetailBasic _Detail;
        public ProductDetailBasic Detail { get => base.GetProperty(this._Detail); set => base.SetProperty(ref this._Detail, value); }


        private BrandBasic _Brand;
        public BrandBasic Brand { get => base.GetProperty(this._Brand); set => base.SetProperty(ref this._Brand, value); }

        private ProductStatusBasic _ProductStatus;

        public ProductStatusBasic ProductStatus { get => base.GetProperty(this._ProductStatus); set => base.SetProperty(ref this._ProductStatus, value); }

        private ManufacturerBasic _Manufacturer;

        public ManufacturerBasic Manufacturer { get => base.GetProperty(this._Manufacturer); set => base.SetProperty(ref this._Manufacturer, value); }
        private SupplierBasic _Supplier;
        public SupplierBasic Supplier { get => base.GetProperty(this._Supplier); set => base.SetProperty(ref this._Supplier, value); }
        
        private List<ProductGroupBasic> _Groups;
        public List<ProductGroupBasic> Groups { get => base.GetProperty(this._Groups); set => base.SetProperty(ref this._Groups, value); }

        private List<ProductCategoryBasic> _Categories;
        public List<ProductCategoryBasic> Categories { get => base.GetProperty(this._Categories); set => base.SetProperty(ref this._Categories, value); }

        
        private List<FileBasic> _Photos;
        public List<FileBasic> Photos { get => base.GetProperty(this._Photos); set => base.SetProperty(ref this._Photos, value); }


        private UnitBasic _Unit;
        public UnitBasic Unit { get => base.GetProperty(this._Unit); set => base.SetProperty(ref this._Unit, value); }

        private MeasureBasic _Measure;
        public MeasureBasic Measure { get => base.GetProperty(this._Measure); set => base.SetProperty(ref this._Measure, value); }

        private List<PriceBasic> _Prices;
        public List<PriceBasic> Prices { get => base.GetProperty(this._Prices); set => base.SetProperty(ref this._Prices, value); }

        private List<AttributeBasic> _Attributes;
        public List<AttributeBasic> Attributes { get => base.GetProperty(this._Attributes); set => base.SetProperty(ref this._Attributes, value); }

        private TaxBasic _Tax;
        public TaxBasic Tax { get => base.GetProperty(this._Tax); set => base.SetProperty(ref this._Tax, value); }

        private List<LabelBasic> _Labels;
        public List<LabelBasic> Labels { get => base.GetProperty(this._Labels); set => base.SetProperty(ref this._Labels, value); }

        private List<OptionBasic> _Options;
        public List<OptionBasic> Options { get => base.GetProperty(this._Options); set => base.SetProperty(ref this._Options, value); }

        private List<SettingBasic> _Settings;
        public List<SettingBasic> Settings { get => base.GetProperty(this._Settings); set => base.SetProperty(ref this._Settings, value); }

        private List<ProductStockBasic> _Stocks;
        public List<ProductStockBasic>Stocks { get => base.GetProperty(this._Stocks); set => base.SetProperty(ref this._Stocks, value); }

        private DataItemList _Dataset;
        public virtual DataItemList Dataset { get => base.GetProperty(this._Dataset); set => base.SetProperty(ref this._Dataset, value); }
        IDataItemList<IDataItemData> IProductData.Dataset { get { return this.Dataset as IDataItemList<IDataItemData>; } set { this.Dataset = (DataItemList)value; } }


        public ProductBasic()
        {
            this.Dataset = new DataItemList();
        }
    }
}
