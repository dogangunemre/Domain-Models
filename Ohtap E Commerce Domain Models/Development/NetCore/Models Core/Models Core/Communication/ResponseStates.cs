using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Core.Communication
{
    public enum ResponseStates
    {
        Unknown = 0,
        Succeed = 1,
        Failed = 2,
        ServiceUnavailable = 3
    }
}
