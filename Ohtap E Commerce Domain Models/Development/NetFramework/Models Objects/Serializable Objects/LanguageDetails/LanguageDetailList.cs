﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.LanguageDetails;
using CoreSystem = Ohtap.ECommerce.Domain.Models.Core.System;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.LanguageDetails
{
    [DataContract]
    [Serializable]
    public class LanguageDetailList : CoreSystem.Lista<ILanguageDetailData>, ILanguageDetailList
    {
    }
}
