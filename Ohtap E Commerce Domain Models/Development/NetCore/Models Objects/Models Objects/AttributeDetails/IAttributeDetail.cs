﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.AttributeDetails
{
    public interface IAttributeDetail : IAttributeDetailData
    {
        Languages.ILanguage Language { get; set; }
    }
}
