﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.LabelDetails
{
    public interface ILabelDetail : ILabelDetailData
    {
        Languages.ILanguage Language { get; set; }
    }
}
