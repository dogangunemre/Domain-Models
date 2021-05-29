using Ohtap.ECommerce.Domain.Models.Objects.Files;
using Ohtap.ECommerce.Domain.Models.Objects.Packages;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.PromotionDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Promotions
{
    public class Promotion : PromotionBasic, IPromotion
    {

        private File _Photo;
        public virtual File Photo { get => base.GetProperty(this._Photo); set => base.SetProperty(ref this._Photo, value); }
        IFileData IPromotion.Photo { get { return this.Photo as Files.IFileData; } set { this.Photo = (Files.File)value; } }


        private PackageList _Packages;
        public virtual PackageList Packages { get => base.GetProperty(this._Packages); set => base.SetProperty(ref this._Packages, value); }
        IPackageDataList<IPackageData> IPromotion.Packages { get { return this.Packages as IPackageDataList<IPackageData>; } set { this.Packages = (PackageList)value; } }

        private ProductList _Products;
        public virtual ProductList Products { get => base.GetProperty(this._Products); set => base.SetProperty(ref this._Products, value); }
        IProductDataList<IProductData> IPromotion.Products { get { return this.Products as IProductDataList<IProductData>; } set { this.Products = (ProductList)value; } }


        private PromotionDetailList _Details;
        public virtual PromotionDetailList Details { get => base.GetProperty(this._Details); set => base.SetProperty(ref this._Details, value); }
        IPromotionDetailDataList<IPromotionDetailData> IPromotion.Details { get { return this.Details as IPromotionDetailDataList<IPromotionDetailData>; } set { this.Details = (PromotionDetailList)value; } }
    }
}
