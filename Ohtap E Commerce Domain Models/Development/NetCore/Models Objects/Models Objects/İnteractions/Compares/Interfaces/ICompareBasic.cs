using Ohtap.ECommerce.Domain.Models.Core.Object;
using Ohtap.ECommerce.Domain.Models.Objects.Customers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Compares.Interfaces
{
    public interface ICompareBasic : IObjectBasic, ICompareInfo
    {
        ICustomerBasic Customer { get; set; }
    }
}
