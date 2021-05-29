using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.ProductGroupDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.ProductGroups
{
    public class ProductGroup : ProductGroupBasic, IProductGroup
    {

        private ProductGroupList _Childs;
        public virtual ProductGroupList Childs { get => base.GetProperty(this._Childs); set => base.SetProperty(ref this._Childs, value); }
        IProductGroupDataList<IProductGroupData> IProductGroup.Childs { get { return this.Childs as IProductGroupDataList<IProductGroupData>; } set { this.Childs = (ProductGroupList)value; } }


        private ProductGroupDetailList _Details;
        public virtual ProductGroupDetailList Details { get => base.GetProperty(this._Details); set => base.SetProperty(ref this._Details, value); }
        IProductGroupDetailDataList<IProductGroupDetailData> IProductGroup.Details { get { return this.Details as IProductGroupDetailDataList<IProductGroupDetailData>; } set { this.Details = (ProductGroupDetailList)value; } }
    }
}
