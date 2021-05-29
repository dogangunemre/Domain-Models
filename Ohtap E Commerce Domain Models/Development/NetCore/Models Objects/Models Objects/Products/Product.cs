using Ohtap.ECommerce.Domain.Models.Objects.Attributes;
using Ohtap.ECommerce.Domain.Models.Objects.Brands;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;
using Ohtap.ECommerce.Domain.Models.Objects.Feedbacks;
using Ohtap.ECommerce.Domain.Models.Objects.Files;
using Ohtap.ECommerce.Domain.Models.Objects.Labels;
using Ohtap.ECommerce.Domain.Models.Objects.LanguageDetails;
using Ohtap.ECommerce.Domain.Models.Objects.Manufacturers;
using Ohtap.ECommerce.Domain.Models.Objects.Measures;
using Ohtap.ECommerce.Domain.Models.Objects.Options;
using Ohtap.ECommerce.Domain.Models.Objects.Prices;
using Ohtap.ECommerce.Domain.Models.Objects.ProductCategories;
using Ohtap.ECommerce.Domain.Models.Objects.ProductDetails;
using Ohtap.ECommerce.Domain.Models.Objects.ProductLabels;
using Ohtap.ECommerce.Domain.Models.Objects.ProductOptions;
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
    public class Product : ProductBasic, IProduct
    {



        private ProductCategoryList _Categories;
        public virtual ProductCategoryList Categories { get => base.GetProperty(this._Categories); set => base.SetProperty(ref this._Categories, value); }
        IProductCategoryDataList<IProductCategoryData> IProduct.Categories { get { return this.Categories as IProductCategoryDataList<IProductCategoryData>; } set { this.Categories = (ProductCategoryList)value; } }


        //private FileList _Photos;
        //public virtual FileList Photos { get => base.GetProperty(this._Photos); set => base.SetProperty(ref this._Photos, value); }
        IFileDataList<IFileData> IProduct.Photos { get { return this.Photos as IFileDataList<IFileData>; } set { this.Photos = (List<FileBasic>)value; } }


        //private Brand _Brand;
        //public virtual Brand Brand { get => base.GetProperty(this._Brand); set => base.SetProperty(ref this._Brand, value); }
        IBrandData IProduct.Brand { get { return this.Brand as IBrandData; } set { this.Brand = (BrandBasic)value; } }


        //private Manufacturer _Manufacturer;
        //public virtual Manufacturer Manufacturer { get => base.GetProperty(this._Manufacturer); set => base.SetProperty(ref this._Manufacturer, value); }
        IManufacturerData IProduct.Manufacturer { get { return this.Manufacturer as IManufacturerData; } set { this.Manufacturer = (ManufacturerBasic)value; } }



        //private Tax _Tax;
        //public virtual Tax Tax { get => base.GetProperty(this._Tax); set => base.SetProperty(ref this._Tax, value); }
        ITaxData IProduct.Tax { get { return this.Tax as ITaxData; } set { this.Tax = (TaxBasic)value; } }


        private MeasureList _Measures;
        public virtual MeasureList Measures { get => base.GetProperty(this._Measures); set => base.SetProperty(ref this._Measures, value); }
        IMeasureDataList<IMeasureData> IProduct.Measures { get { return this.Measures as IMeasureDataList<IMeasureData>; } set { this.Measures = (MeasureList)value; } }

        //private PriceList _Prices;
        //public virtual PriceList Prices { get => base.GetProperty(this._Prices); set => base.SetProperty(ref this._Prices, value); }
        IPriceDataList<IPriceData> IProduct.Prices { get { return this.Prices as IPriceDataList<IPriceData>; } set { this.Prices = (List<PriceBasic>)value; } }


        //private OptionList _Options;
        //public virtual OptionList Options { get => base.GetProperty(this._Options); set => base.SetProperty(ref this._Options, value); }
        IOptionDataList<IOptionData> IProduct.Options { get { return this.Options as IOptionDataList<IOptionData>; } set { this.Options = (List<OptionBasic>)value; } }

        //private LabelList _Labels;
        //public virtual LabelList Labels { get => base.GetProperty(this._Labels); set => base.SetProperty(ref this._Labels, value); }
        ILabelDataList<ILabelData> IProduct.Labels { get { return this.Labels as ILabelDataList<ILabelData>; } set { this.Labels = (List<LabelBasic>)value; } }


        private FeedbackList _Feedbacks;
        public virtual FeedbackList Feedbacks { get => base.GetProperty(this._Feedbacks); set => base.SetProperty(ref this._Feedbacks, value); }
        IFeedbackDataList<IFeedbackData> IProduct.Feedbacks { get { return this.Feedbacks as IFeedbackDataList<IFeedbackData>; } set { this.Feedbacks = (FeedbackList)value; } }


        //private AttributeList _Attributes;
        //public virtual AttributeList Attributes { get => base.GetProperty(this._Attributes); set => base.SetProperty(ref this._Attributes, value); }
        IAttributeDataList<IAttributeData> IProduct.Attributes { get { return this.Attributes as IAttributeDataList<IAttributeData>; } set { this.Attributes = (List<AttributeBasic>)value; } }


        private DiscountList _Discounts;
        public virtual DiscountList Discounts { get => base.GetProperty(this._Discounts); set => base.SetProperty(ref this._Discounts, value); }
        IDiscountDataList<IDiscountData> IProduct.Discounts { get { return this.Discounts as IDiscountDataList<IDiscountData>; } set { this.Discounts = (DiscountList)value; } }


        private WarehouseList _Warehouses;
        public virtual WarehouseList Warehouses { get => base.GetProperty(this._Warehouses); set => base.SetProperty(ref this._Warehouses, value); }
        IWarehouseDataList<IWarehouseData> IProduct.Warehouses { get { return this.Warehouses as IWarehouseDataList<IWarehouseData>; } set { this.Warehouses = (WarehouseList)value; } }


        private SpecificationList _Specifications;
        public virtual SpecificationList Specifications { get => base.GetProperty(this._Specifications); set => base.SetProperty(ref this._Specifications, value); }
        ISpecificationDataList<ISpecificationData> IProduct.Specifications { get { return this.Specifications as ISpecificationDataList<ISpecificationData>; } set { this.Specifications = (SpecificationList)value; } }


        private ProductDetailList _Details;
        public virtual ProductDetailList Details { get => base.GetProperty(this._Details); set => base.SetProperty(ref this._Details, value); }
        IProductDetailDataList<IProductDetailData> IProduct.Details { get { return this.Details as IProductDetailDataList<IProductDetailData>; } set { this.Details = (ProductDetailList)value; } }

    }
}
