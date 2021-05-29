using Ohtap.ECommerce.Domain.Models.Objects.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Warehouses
{
    public class WarehouseBasic : IWarehouseData
    {
        public virtual Addresses.IAddressData Address { get; set; }
        public virtual string ID { get; set; }
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual int Order { get; set; }
        public virtual string Description { get; set; }
        public virtual int State { get; set; }
        public virtual string EMail { get; set; }
        public virtual string Fax { get; set; }
        public virtual IStoreData Store { get; set; }
        public virtual string Phone { get; set; }

        
    }
}
