using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;
using Ohtap.ECommerce.Domain.Models.Objects.Regions;

namespace Ohtap.ECommerce.Domain.Models.Objects.Taxes.Interfaces
{
    public interface ITaxBasic : IObjectBasic, ITaxInfo
    {
        public decimal Value { get; set; }
        public RegionBasic Region { get; set; }
    }
}
