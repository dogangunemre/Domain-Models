using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.OptionDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Options
{
    public class Option : OptionBasic, IOption
    {
        private OptionDetailList _Details;
        public virtual OptionDetailList Details { get => base.GetProperty(this._Details); set => base.SetProperty(ref this._Details, value); }
        IOptionDetailDataList<IOptionDetailData> IOption.Details { get { return this.Details as IOptionDetailDataList<IOptionDetailData>; } set { this.Details = (OptionDetailList)value; } }
    }
}
