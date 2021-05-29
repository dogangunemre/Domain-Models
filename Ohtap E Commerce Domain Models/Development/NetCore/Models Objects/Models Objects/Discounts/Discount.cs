using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.DiscountDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Discounts
{
    public class Discount : DiscountBasic, IDiscount
    {
        private DiscountDetailList _Details;
        public virtual DiscountDetailList Details { get => base.GetProperty(this._Details); set => base.SetProperty(ref this._Details, value); }
        IDiscountDetailDataList<IDiscountDetailData> IDiscount.Details { get { return this.Details as IDiscountDetailDataList<IDiscountDetailData>; } set { this.Details = (DiscountDetailList)value; } }
    }
}
