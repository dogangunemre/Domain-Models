using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.Orders
{
    public interface IOrderData :  CoreObject.IObjectID, CoreObject.IObjectTitle, CoreObject.IObjectName, CoreObject.IObjectOrder, CoreObject.IObjectDescription, CoreObject.IObjectState, IOrderTotalPrice, IOrderStore, IOrderNote
    {

    }
}
