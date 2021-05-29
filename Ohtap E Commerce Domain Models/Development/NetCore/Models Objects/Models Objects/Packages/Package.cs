using Ohtap.ECommerce.Domain.Models.Objects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.ProductCategories;
using Ohtap.ECommerce.Domain.Models.Objects.Taxes;
using Ohtap.ECommerce.Domain.Models.Objects.Files;
using Ohtap.ECommerce.Domain.Models.Objects.PackageOptions;
using Ohtap.ECommerce.Domain.Models.Objects.PackageLabels;
using Ohtap.ECommerce.Domain.Models.Objects.Feedbacks;
using Ohtap.ECommerce.Domain.Models.Objects.PackageAttributes;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;
using Ohtap.ECommerce.Domain.Models.Objects.Warehouses;
using Ohtap.ECommerce.Domain.Models.Objects.Options;
using Ohtap.ECommerce.Domain.Models.Objects.Labels;
using Ohtap.ECommerce.Domain.Models.Objects.Attributes;
using Ohtap.ECommerce.Domain.Models.Objects.Specifications;
using Ohtap.ECommerce.Domain.Models.Objects.PackageDetails;

namespace Ohtap.ECommerce.Domain.Models.Objects.Packages
{
    public class Package : PackageBasic, IPackage
    {

        private ProductCategoryList _Categories;
        public virtual ProductCategoryList Categories { get => base.GetProperty(this._Categories); set => base.SetProperty(ref this._Categories, value); }
        IProductCategoryDataList<IProductCategoryData> IPackage.Categories { get { return this.Categories as IProductCategoryDataList<IProductCategoryData>; } set { this.Categories = (ProductCategoryList)value; } }


        private FileList _Photos;
        public virtual FileList Photos { get => base.GetProperty(this._Photos); set => base.SetProperty(ref this._Photos, value); }
        IFileDataList<IFileData> IPackage.Photos { get { return this.Photos as IFileDataList<IFileData>; } set { this.Photos = (FileList)value; } }

        private Tax _Tax;
        public virtual Tax Tax { get => base.GetProperty(this._Tax); set => base.SetProperty(ref this._Tax, value); }
        ITaxData IPackage.Tax { get { return this.Tax as ITaxData; } set { this.Tax = (Tax)value; } }

        private OptionList _Options;
        public virtual OptionList Options { get => base.GetProperty(this._Options); set => base.SetProperty(ref this._Options, value); }
        IOptionDataList<IOptionData> IPackage.Options { get { return this.Options as IOptionDataList<IOptionData>; } set { this.Options = (OptionList)value; } }


        private LabelList _Labels;
        public virtual LabelList Labels { get => base.GetProperty(this._Labels); set => base.SetProperty(ref this._Labels, value); }
        ILabelDataList<ILabelData> IPackage.Labels { get { return this.Labels as ILabelDataList<ILabelData>; } set { this.Labels = (LabelList)value; } }

        private FeedbackList _Feedbacks;
        public virtual FeedbackList Feedbacks { get => base.GetProperty(this._Feedbacks); set => base.SetProperty(ref this._Feedbacks, value); }
        IFeedbackDataList<IFeedbackData> IPackage.Feedbacks { get { return this.Feedbacks as IFeedbackDataList<IFeedbackData>; } set { this.Feedbacks = (FeedbackList)value; } }

        private AttributeList _Attributes;
        public virtual AttributeList Attributes { get => base.GetProperty(this._Attributes); set => base.SetProperty(ref this._Attributes, value); }
        IAttributeDataList<IAttributeData> IPackage.Attributes { get { return this.Attributes as IAttributeDataList<IAttributeData>; } set { this.Attributes = (AttributeList)value; } }

        private DiscountList _Discounts;
        public virtual DiscountList Discounts { get => base.GetProperty(this._Discounts); set => base.SetProperty(ref this._Discounts, value); }
        IDiscountDataList<IDiscountData> IPackage.Discounts { get { return this.Discounts as IDiscountDataList<IDiscountData>; } set { this.Discounts = (DiscountList)value; } }

        private WarehouseList _Warehouses;
        public virtual WarehouseList Warehouses { get => base.GetProperty(this._Warehouses); set => base.SetProperty(ref this._Warehouses, value); }
        IWarehouseDataList<IWarehouseData> IPackage.Warehouses { get { return this.Warehouses as IWarehouseDataList<IWarehouseData>; } set { this.Warehouses = (WarehouseList)value; } }

        private SpecificationList _Specifications;
        public virtual SpecificationList Specifications { get => base.GetProperty(this._Specifications); set => base.SetProperty(ref this._Specifications, value); }
        ISpecificationDataList<ISpecificationData> IPackage.Specifications { get { return this.Specifications as ISpecificationDataList<ISpecificationData>; } set { this.Specifications = (SpecificationList)value; } }

        private PackageDetailList _Details;
        public virtual PackageDetailList Details { get => base.GetProperty(this._Details); set => base.SetProperty(ref this._Details, value); }
        IPackageDetailDataList<IPackageDetailData> IPackage.Details { get { return this.Details as IPackageDetailDataList<IPackageDetailData>; } set { this.Details = (PackageDetailList)value; } }

    }
}
