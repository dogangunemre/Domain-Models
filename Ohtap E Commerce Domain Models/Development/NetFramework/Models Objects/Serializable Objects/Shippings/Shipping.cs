using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Cargos;
using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Cargos;
using Ohtap.ECommerce.Domain.Models.Objects.Payments;
using Ohtap.ECommerce.Domain.Models.Objects.Shippings;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Shippings
{
    public class Shipping : ShippingBasic, IShipping
    {
        public IPaymentData Payment { get; set; }
        public ICargoData Cargo { get; set; }
    }
}
