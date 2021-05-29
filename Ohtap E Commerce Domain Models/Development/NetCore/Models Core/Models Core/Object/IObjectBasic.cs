using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Core.Object
{
    public interface IObjectBasic : IObjectInfo, IObjectDescription, IObjectOrder, IObjectState
    {
    }
}
