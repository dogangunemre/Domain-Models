using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Core.Communication
{
    public interface IMessage
    {
        string InfoCode { get; set; }
        string Title { get; set; }
        string Description { get; set; }
    }
}
