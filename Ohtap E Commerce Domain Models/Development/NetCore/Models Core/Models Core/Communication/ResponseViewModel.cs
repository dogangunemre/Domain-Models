using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Core.Communication
{
    public class ResponseViewModel<T, P> : ResponseViewModelBase, IResponseViewModel<T, P>
        where T : IRequestData, new()
        where P : IResponseData, new()
    {
        public T RequestData { set; get; }
        public P ResponseData { set; get; }

        IMessageList<IMessage> IResponseViewModel<T, P>.Messages { get { return this.Messages as IMessageList<IMessage>; } set { this.Messages = (MessageList)value; } }

        public ResponseViewModel() : base()
        {
            this.ResponseData = new P();
        }
        public ResponseViewModel(T RequestData) : base()
        {
            this.RequestData = RequestData;
            this.ResponseData = new P();
        }
    }
}
