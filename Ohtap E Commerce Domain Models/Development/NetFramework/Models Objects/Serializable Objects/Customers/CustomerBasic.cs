using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Customers;
using Ohtap.ECommerce.Domain.Models.Objects.Files;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Customers
{
    public class CustomerBasic : ICustomerData
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public string CitizenNumber { get; set; }
        public string Gender { get; set; }
        public IFileData Photo { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public long DateOfBirth { get; set; }
        public string Nationality { get; set; }
    }
}
