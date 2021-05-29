using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Core.Communication
{
    public class Message : IMessage
    {
        public string InfoCode { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }


        public Message()
        {

        }      
        public Message(string InfoCode, string Title, string Description = null)
        {
            this.InfoCode = InfoCode;
            this.Title = Title;
            this.Description = Description;
        }
    }
   
}
