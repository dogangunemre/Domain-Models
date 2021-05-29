using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Addresses;

namespace Ohtap.ECommerce.Domain.Models.Objects.Cargos
{
    public interface ICargo : ICargoData
    {
        IAddressData Address { get; set; }
    }
}
