using Ohtap.ECommerce.Domain.Models.Core.Object;
using Ohtap.ECommerce.Domain.Models.Objects.Banks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.BankAccounts.Interfaces
{
    public interface IBankAccountBasic : IObjectBasic, IBankAccountInfo
    {
        public string Branch { get; set; }
        public string Number { get; set; }
        public string IBAN { get; set; }
        public string SwiftCode { get; set; }
        public string Type { get; set; }
        
        public BankBasic Bank { get; set; }
    }
}
