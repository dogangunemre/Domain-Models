using Ohtap.ECommerce.Domain.Models.Core.Object;
using Ohtap.ECommerce.Domain.Models.Objects.Regions;

using System;
using System.Collections.Generic;
using System.Text;
using Ohtap.ECommerce.Domain.Models.Objects.Files;
using Ohtap.ECommerce.Domain.Models.Objects.Files.Interfaces;

namespace Ohtap.ECommerce.Domain.Models.Objects.Customers.Interfaces
{
    public interface ICustomerBasic : IObjectBasic, ICustomerInfo
    {
        public string EMail { get; set; }
        public string Phone { get; set; }
        public string CitizenNumber { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
       
        RegionBasic Region { get; set; }

    }
}
