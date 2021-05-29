﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Coupons
{
    public interface ICouponList <T>: ICouponDataList<T>
        where T: ICouponData
    {
    }
}