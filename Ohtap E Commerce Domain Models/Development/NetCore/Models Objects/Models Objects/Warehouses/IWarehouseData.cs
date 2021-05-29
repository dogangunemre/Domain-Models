﻿using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Objects.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.Warehouses
{
    public interface IWarehouseData :  CoreObject.IObjectID, CoreObject.IObjectCode, CoreObject.IObjectName, CoreObject.IObjectOrder, CoreObject.IObjectDescription, CoreObject.IObjectState,IWarehouseEMail ,IWarehouseFax, IWarehousePhone
    {
        StoreBasic Store { get; set; }
        IDataItemList<IDataItemData> Dataset { get; set; }
    }
}