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
        private Address _Address;
        public virtual Address Address { get => base.GetProperty(this._Address); set => base.SetProperty(ref this._Address, value); }
        IAddress IBank.Address { get { return this.Address as IAddress; } set { this.Address = (Address)value; } }
    }
}
