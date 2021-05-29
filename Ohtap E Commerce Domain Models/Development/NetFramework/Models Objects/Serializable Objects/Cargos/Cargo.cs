using Ohtap.ECommerce.Domain.Models.Objects.Addresses;
using Ohtap.ECommerce.Domain.Models.Objects.Cargos;
using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Addresses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Cargos
{
    public class Cargo : CargoBasic, ICargo
    {
        public IAddressData Address { get; set; }
    }
}
