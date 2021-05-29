using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.PropertyDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Properties
{
    public class Property : PropertyBasic, IProperty
    {
        private PropertyDetailList _Details;
        public virtual PropertyDetailList Details { get => base.GetProperty(this._Details); set => base.SetProperty(ref this._Details, value); }
        IPropertyDetailDataList<IPropertyDetailData> IProperty.Details { get { return this.Details as IPropertyDetailDataList<IPropertyDetailData>; } set { this.Details = (PropertyDetailList)value; } }
    }
}
