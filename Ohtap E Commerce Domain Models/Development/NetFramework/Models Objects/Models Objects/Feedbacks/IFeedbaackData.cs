﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.Languages
{
    public interface ILanguageData : CoreObject.IObjectID, CoreObject.IObjectCode, CoreObject.IObjectName, ILanguageLanguageCode, CoreObject.IObjectOrder, CoreObject.IObjectDescription, CoreObject.IObjectState
    {
    }
}