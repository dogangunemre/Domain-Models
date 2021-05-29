using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Banks.Interfaces
{
    public interface IBankBasic : IObjectBasic, IBankInfo
    {
        public string Phone { get; set; }
        public string EMail { get; set; }
        
        public  string Fax { get; set; }

    }
}
