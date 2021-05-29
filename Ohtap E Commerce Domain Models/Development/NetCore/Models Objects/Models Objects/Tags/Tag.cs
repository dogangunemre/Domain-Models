using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.TagDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Tags
{
    public class Tag : TagBasic, ITag
    {

        private TagDetailList _Details;
        public virtual TagDetailList Details { get => base.GetProperty(this._Details); set => base.SetProperty(ref this._Details, value); }
        ITagDetailDataList<ITagDetailData> ITag.Details { get { return this.Details as ITagDetailDataList<ITagDetailData>; } set { this.Details = (TagDetailList)value; } }
    }
}
