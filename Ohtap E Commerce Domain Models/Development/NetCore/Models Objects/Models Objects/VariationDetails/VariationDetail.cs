﻿using Ohtap.ECommerce.Domain.Models.Objects.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.VariationDetails
{
    public class VariationDetail : VariationDetailBasic, IVariationDetail
    {

        private Language _Language;
        public virtual Language Language { get => base.GetProperty(this._Language); set => base.SetProperty(ref this._Language, value); }
        ILanguage IVariationDetail.Language { get { return this.Language as ILanguage; } set { this.Language = (Language)value; } }
    }
}
