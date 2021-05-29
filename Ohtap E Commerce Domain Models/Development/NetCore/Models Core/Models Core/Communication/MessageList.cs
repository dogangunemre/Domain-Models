using Ohtap.ECommerce.Domain.Models.Core.System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Core.Communication
{
    public class MessageList : Lista<Message>, IMessageList<Message>
    {
        public MessageList() : base()
        {

        }
        public void Add(string InfoCode, string Title, string Description = null)
        {
            base.Add(new Message(InfoCode, Title, Description));
        }
    }
}
