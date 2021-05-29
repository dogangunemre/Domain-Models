using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Customers
{
    public  class CustomerBasic : ICustomerData
    {
        public virtual string ID { get; set; }
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual int Order { get; set; }
        public virtual string Description { get; set; }
        public virtual int State { get; set; }
        public virtual string CitizenNumber { get; set; }
        public virtual string Gender { get; set; }
        public virtual Files.IFileData Photo { get; set; }
        public virtual string Phone { get; set; }
        public virtual string EMail { get; set; }
        public virtual long DateOfBirth { get; set; }
        public virtual string Nationality { get; set; }
    }
}
