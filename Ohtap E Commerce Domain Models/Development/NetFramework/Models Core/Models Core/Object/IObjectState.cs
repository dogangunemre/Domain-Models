using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Core.Object
{
    public interface IObjectState
    {
        int State { set; get; }
    }
}
