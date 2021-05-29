﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Variations
{
    public interface IVariationList<T> : IVariationDataList<T>
        where T: IVariationData
    {
    }
}