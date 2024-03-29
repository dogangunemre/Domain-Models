﻿using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Orders.Interfaces
{
    public interface IOrderBasic : IObjectBasic, IOrderInfo
    {
        string Symbol { get; set; }
        string FundCode { get; set; }
    }
}
