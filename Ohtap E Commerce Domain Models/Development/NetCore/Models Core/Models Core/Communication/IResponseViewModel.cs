using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Core.Communication
{
    public interface IResponseViewModel<T, P>
        where T : IRequestData, new()
        where P : IResponseData, new()
    {
        T RequestData { set; get; }
        P ResponseData { set; get; }
        IMessageList<IMessage> Messages { set; get; }
        ResponseStates State { set; get; }
    }
}
