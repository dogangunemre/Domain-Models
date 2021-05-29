using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.ProductCategoryDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductCategories
{
    public class ProductCategory : ProductCategoryBasic, IProductCategory
    {
        private ProductCategoryList _Childs;
        public virtual ProductCategoryList Childs { get => base.GetProperty(this._Childs); set => base.SetProperty(ref this._Childs, value); }
        IProductCategoryDataList<IProductCategoryData> IProductCategory.Childs { get { return this.Childs as IProductCategoryDataList<IProductCategoryData>; } set { this.Childs = (ProductCategoryList)value; } }


        private ProductCategoryDetailList _Details;
        public virtual ProductCategoryDetailList Details { get => base.GetProperty(this._Details); set => base.SetProperty(ref this._Details, value); }
        IProductCategoryDetailDataList<IProductCategoryDetailData> IProductCategory.Details { get { return this.Details as IProductCategoryDetailDataList<IProductCategoryDetailData>; } set { this.Details = (ProductCategoryDetailList)value; } }
    }
}
