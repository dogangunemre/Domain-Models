using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Stores.Interfaces
{
    public interface IStoreBasic : IObjectBasic, IStoreInfo
    {
        public string Phone { get; set; }
        public string EMail { get; set; }
        public string Fax { get; set; }


    }
}
