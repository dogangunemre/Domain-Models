using Ohtap.ECommerce.Domain.Models.Core.Object;
using Ohtap.ECommerce.Domain.Models.Objects.Files;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Brands.Interfaces
{
    public interface IBrandBasic : IObjectBasic, IBrandInfo
    {
        
        public File Logo { get; set; }
    }
}
