using Ohtap.ECommerce.Domain.Models.Objects.LanguageDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Languages
{
    public class Language : LanguageBasic, ILanguage
    {
        private LanguageDetailList _Details;
        public virtual LanguageDetailList Details { get => base.GetProperty(this._Details); set => base.SetProperty(ref this._Details, value); }
        ILanguageDetailDataList<ILanguageDetailData> ILanguage.Details { get { return this.Details as ILanguageDetailDataList<ILanguageDetailData>; } set { this.Details = (LanguageDetailList)value; } }

    }
}
