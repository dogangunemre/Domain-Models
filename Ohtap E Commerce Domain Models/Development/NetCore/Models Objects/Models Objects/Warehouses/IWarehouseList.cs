﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Warehouses
{
    public interface IWarehouseList<T> : IWarehouseDataList<T>
        where T: IWarehouseData
    {
    }
}