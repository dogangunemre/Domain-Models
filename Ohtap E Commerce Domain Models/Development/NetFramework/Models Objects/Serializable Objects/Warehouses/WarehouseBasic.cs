using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Addresses;
using Ohtap.ECommerce.Domain.Models.Objects.Stores;
using Ohtap.ECommerce.Domain.Models.Objects.Warehouses;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Warehouses
{
    public class WarehouseBasic : IWarehouseData
    {
        public IAddressData Address { get; set; }
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public string EMail { get; set; }
        public string Fax { get; set; }
        public IStoreData Store { get; set; }
        public string Phone { get; set; }

        
    }
}
