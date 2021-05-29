using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.BankAccounts.Interfaces;
using Ohtap.ECommerce.Domain.Models.Objects.Banks.Interfaces;
using Ohtap.ECommerce.Domain.Models.Objects.Banks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.BankAccounts.Objects
{
    public class BankAccountBasic : BankAccountInfo, IBankAccountBasic
    {
        private int _Order;
        public virtual int Order { get => base.GetProperty(this._Order); set => base.SetProperty(ref this._Order, value); }

        private string _Description;
        public virtual string Description { get => base.GetProperty(this._Description); set => base.SetProperty(ref this._Description, value); }

        private int _State;
        public virtual int State { get => base.GetProperty(this._State); set => base.SetProperty(ref this._State, value); }

        private string _Branch;
        public virtual string Branch { get => base.GetProperty(this._Branch); set => base.SetProperty(ref this._Branch, value); }
        private string _Number;
        public virtual string Number { get => base.GetProperty(this._Number); set => base.SetProperty(ref this._Number, value); }

        private string _IBAN;
        public virtual string IBAN { get => base.GetProperty(this._IBAN); set => base.SetProperty(ref this._IBAN, value); }

        private string _SwiftCode;
        public virtual string SwiftCode { get => base.GetProperty(this._SwiftCode); set => base.SetProperty(ref this._SwiftCode, value); }

        private string _Type;
        public virtual string Type { get => base.GetProperty(this._Type); set => base.SetProperty(ref this._Type, value); }

        private BankBasic _Bank;
        public virtual BankBasic Bank { get => base.GetProperty(this._Bank); set => base.SetProperty(ref this._Bank, value); }
    }
}
