using Ohtap.ECommerce.Domain.Models.Objects.Packages;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Relations
{
    public class Relation : RelationBasic, IRelation
    {

        private ProductList _Products;
        public virtual ProductList Products { get => base.GetProperty(this._Products); set => base.SetProperty(ref this._Products, value); }
        IProductDataList<IProductData> IRelation.Products { get { return this.Products as IProductDataList<IProductData>; } set { this.Products = (ProductList)value; } }



        private PackageList _Packages;
        public virtual PackageList Packages { get => base.GetProperty(this._Packages); set => base.SetProperty(ref this._Packages, value); }
        IPackageDataList<IPackageData> IRelation.Packages { get { return this.Packages as IPackageDataList<IPackageData>; } set { this.Packages = (PackageList)value; } }
    }
}
