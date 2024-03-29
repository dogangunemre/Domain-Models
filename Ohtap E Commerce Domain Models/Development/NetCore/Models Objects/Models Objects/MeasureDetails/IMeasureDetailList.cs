﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.MeasureDetails
{
    public interface IMeasureDetailList <T>: IMeasureDetailDataList<T>
        where T : IMeasureDetailData
    {
    }
}
