using Ohtap.ECommerce.Domain.Models.Objects.LabelDetails;
using Ohtap.ECommerce.Domain.Models.Core.System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Labels
{
    public class Label : LabelBasic, ILabel
    {
        private LabelDetailList  _Details;
        public virtual LabelDetailList  Details { get => base.GetProperty(this._Details); set => base.SetProperty(ref this._Details, value); }
        ILabelDetailDataList<ILabelDetailData> ILabel.Details { get { return this.Details as ILabelDetailDataList<ILabelDetailData>; } set { this.Details = (LabelDetailList)value; } }
    }
}
