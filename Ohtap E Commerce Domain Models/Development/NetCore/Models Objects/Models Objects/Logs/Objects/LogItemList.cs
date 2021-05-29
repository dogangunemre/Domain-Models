using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Logs.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Logs.Objects
{
    public class LogItemList<T> : Lista<T>, ILogItemList<T>
        where T : ILogIdentity
    {
    }
}
