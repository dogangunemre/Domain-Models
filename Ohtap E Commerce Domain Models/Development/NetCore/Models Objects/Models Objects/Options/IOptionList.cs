﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Options
{
    public interface IOptionList <T>: IOptionDataList<T>
        where T : IOptionData
    {
    }
}
