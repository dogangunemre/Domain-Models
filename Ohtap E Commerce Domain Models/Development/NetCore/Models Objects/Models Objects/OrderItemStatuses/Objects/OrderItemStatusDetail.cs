﻿using Ohtap.ECommerce.Domain.Models.Core.Object;
using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.OrderItemStatuses.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.OrderItemStatuses.Objects
{
    public class OrderItemStatusDetail : OrderItemStatus, Interfaces.IOrderItemStatusDetail
    {
    }
}
