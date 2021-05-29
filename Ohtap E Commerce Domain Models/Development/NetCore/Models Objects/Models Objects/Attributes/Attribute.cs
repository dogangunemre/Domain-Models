using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.AttributeDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Attributes
{
    public class Attribute : AttributeBasic, IAttribute
    {
        private AttributeDetailList _Details;
        public virtual AttributeDetailList Details { get => base.GetProperty(this._Details); set => base.SetProperty(ref this._Details, value); }
        IAttributeDetailDataList<IAttributeDetailData> IAttribute.Details { get { return this.Details as IAttributeDetailDataList<IAttributeDetailData>; } set { this.Details = (AttributeDetailList)value; } }

    }   
}


