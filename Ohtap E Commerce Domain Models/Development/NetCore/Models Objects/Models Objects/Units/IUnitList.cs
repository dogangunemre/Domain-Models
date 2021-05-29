﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Units
{
    public interface IUnitList<T> : IUnitDataList<T>
        where T: IUnitData
    {
    }
}
