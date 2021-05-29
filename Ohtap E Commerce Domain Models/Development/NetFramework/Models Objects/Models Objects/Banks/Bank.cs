using Ohtap.ECommerce.Domain.Models.Objects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Addresses;

namespace Ohtap.ECommerce.Domain.Models.Objects.Banks
{
    public class Bank : BankBasic, IBank
    {
        public virtual IAddress Address { get; set; }
    }
}
