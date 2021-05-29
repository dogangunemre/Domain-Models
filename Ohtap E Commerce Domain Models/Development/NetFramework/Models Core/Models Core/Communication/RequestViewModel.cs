using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Core.Communication
{
    public class RequestViewModel<T> : IRequestViewModel<T>
            where T : IRequestData, new()
    {
        public T RequestData { set; get; }

        public RequestViewModel()
        {
            this.RequestData = new T();
        }
    }
}
