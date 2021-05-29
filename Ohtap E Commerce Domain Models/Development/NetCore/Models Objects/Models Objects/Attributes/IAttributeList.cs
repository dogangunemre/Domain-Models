﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Attributes
{
    public interface IAttributeList<T> : IAttributeDataList<T>
        where T: IAttributeData
    {
    }
}