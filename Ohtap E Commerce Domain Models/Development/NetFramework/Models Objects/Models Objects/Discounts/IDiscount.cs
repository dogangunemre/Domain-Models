﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Discounts
{
    public interface IDiscount : IDiscountData
    {
        DiscountDetails.IDiscountDetailDataList Details { set; get; }
      
    }
}
