using Ohtap.ECommerce.Domain.Models.Objects.Addresses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Addresses
{
    public class AddressBasic : IAddressData
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public string FullAddress { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}
