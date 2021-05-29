﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.RegionDetails
{
    public interface IRegionDetailList<T> : IRegionDetailDataList<T>
        where T: IRegionDetailData
    {
    }
}
