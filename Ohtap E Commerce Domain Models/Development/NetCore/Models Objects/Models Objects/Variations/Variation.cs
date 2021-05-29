using Ohtap.ECommerce.Domain.Models.Objects.Packages;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.VariationDetails;
using Ohtap.ECommerce.Domain.Models.Core.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Variations
{
    public class Variation : VariationBasic, IVariation
    {
        private ProductList _Product;
        public virtual ProductList Products { get => base.GetProperty(this._Product); set => base.SetProperty(ref this._Product, value); }
        IProductDataList<IProductData> IVariation.Products { get { return this.Products as IProductDataList<IProductData>; } set { this.Products = (ProductList)value; } }


        private PackageList _Packages;
        public virtual PackageList Packages { get => base.GetProperty(this._Packages); set => base.SetProperty(ref this._Packages, value); }
        IPackageDataList<IPackageData> IVariation.Packages { get { return this.Packages as IPackageDataList<IPackageData>; } set { this.Packages = (PackageList)value; } }



        private VariationDetailList _Details;
        public virtual VariationDetailList Details { get => base.GetProperty(this._Details); set => base.SetProperty(ref this._Details, value); }
        IVariationDetailDataList<IVariationDetailData> IVariation.Details { get { return this.Details as IVariationDetailDataList<IVariationDetailData>; } set { this.Details = (VariationDetailList)value; } }
    }
}
