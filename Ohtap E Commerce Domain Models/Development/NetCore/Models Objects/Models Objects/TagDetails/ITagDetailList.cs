﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.TagDetails
{
    public interface ITagDetailList <T>: ITagDetailDataList<T>
        where T : ITagDetailData
    {
    }
}