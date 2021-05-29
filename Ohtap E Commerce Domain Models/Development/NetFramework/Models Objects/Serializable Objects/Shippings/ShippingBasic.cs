using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Addresses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Addresses;
using Ohtap.ECommerce.Domain.Models.Objects.Shippings;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Shippings
{
    public class ShippingBasic : IShippingData
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public IAddressData Address { get; set; }
    }
}
