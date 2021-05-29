using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Addresses
{
    public class AddressBasic : IAddressData
    {
        public virtual string ID { get; set; }
        public virtual string Title { get; set; }
        public virtual int Order { get; set; }
        public virtual string Description { get; set; }
        public virtual int State { get; set; }
        public virtual string FullAddress { get; set; }
        public virtual string PostCode { get; set; }
        public virtual string Country { get; set; }
        public virtual string City { get; set; }
    }
}
