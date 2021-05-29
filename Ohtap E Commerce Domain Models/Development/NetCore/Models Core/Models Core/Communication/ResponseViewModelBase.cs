using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Core.Communication
{
    public class ResponseViewModelBase
    {
        public MessageList Messages { set; get; }
        public ResponseStates State { set; get; }

        public ResponseViewModelBase()
        {
            this.Messages = new MessageList();
            this.State = ResponseStates.Unknown;
        }
    }
}
