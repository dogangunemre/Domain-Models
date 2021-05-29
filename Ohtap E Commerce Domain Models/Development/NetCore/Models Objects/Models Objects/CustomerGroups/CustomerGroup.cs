using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.CustomerGroupDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.CustomerGroups
{
    public class CustomerGroup : CustomerGroupBasic, ICustomerGroup
    {

        private CustomerGroupDetailList _Childs;
        public virtual CustomerGroupDetailList Childs { get => base.GetProperty(this._Childs); set => base.SetProperty(ref this._Childs, value); }
        ICustomerGroupDetailDataList<ICustomerGroupDetailData> ICustomerGroup.Childs { get { return this.Childs as ICustomerGroupDetailDataList<ICustomerGroupDetailData>; } set { this.Childs = (CustomerGroupDetailList)value; } }

        private CustomerGroupDetailList _Details;
        public virtual CustomerGroupDetailList Details { get => base.GetProperty(this._Details); set => base.SetProperty(ref this._Details, value); }
        ICustomerGroupDetailDataList<ICustomerGroupDetailData> ICustomerGroup.Details { get { return this.Details as ICustomerGroupDetailDataList<ICustomerGroupDetailData>; } set { this.Details = (CustomerGroupDetailList)value; } }
    }
}
