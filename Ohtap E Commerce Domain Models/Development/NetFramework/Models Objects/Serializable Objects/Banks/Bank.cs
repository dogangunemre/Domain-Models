using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Addresses;
using Ohtap.ECommerce.Domain.Models.Objects.Banks;
using Ohtap.ECommerce.Domain.Models.Objects.Addresses;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Banks
{
    public class Bank : BankBasic, IBank
    {
        public IAddress Address { get; set; }
    }
}
