using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Addresses;

namespace Ohtap.ECommerce.Domain.Models.Objects.Banks
{
    public interface IBank : IBankData
    {
        IAddress Address { get; set; }
    }
}
