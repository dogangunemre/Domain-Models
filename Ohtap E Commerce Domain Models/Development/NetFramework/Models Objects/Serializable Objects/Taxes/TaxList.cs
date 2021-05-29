﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Taxes;
using CoreSystem = Ohtap.ECommerce.Domain.Models.Core.System;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Taxes
{
    public class TaxList : CoreSystem.Lista<ITaxData>, ITaxList
    {
        
    }
}
