﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Warehouses
{
    public interface IWarehouseStore
    {
        Stores.IStoreData Store { get; set; }
    }
}
