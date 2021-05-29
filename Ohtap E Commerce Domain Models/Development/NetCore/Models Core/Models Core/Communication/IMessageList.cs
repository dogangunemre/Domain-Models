using Ohtap.ECommerce.Domain.Models.Core.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Core.Communication
{
    public interface IMessageList<T> : ILista<T>
        where T : IMessage
    {
        void Add(string InfoCode, string Title, string Description = null);
    }
}
