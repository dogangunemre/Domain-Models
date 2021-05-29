using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;
using Ohtap.ECommerce.Domain.Models.Objects.Regions;

namespace Ohtap.ECommerce.Domain.Models.Objects.Addresses.Interfaces
{
    public interface IAddressBasic : IObjectBasic, IAddressInfo
    {
        string PostCode { get; set; }
        string FullAddress { get; set; }
        
        RegionBasic Region { get; set; }


        
        
    }
}
