using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Objects.Banks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.BankAccounts
{
    public class BankAccountBasic :Objecta, IBankAccountData
    {
        
        private string _ID;
        public virtual string ID { get => base.GetProperty(this._ID); set => base.SetProperty(ref this._ID, value); }

        private string _Code;
        public virtual string Code { get => base.GetProperty(this._Code); set => base.SetProperty(ref this._Code, value); }

        private string _Name;
        public virtual string Name { get => base.GetProperty(this._Name); set => base.SetProperty(ref this._Name, value); }

        private string _Branch;
        public virtual string Branch { get => base.GetProperty(this._Branch); set => base.SetProperty(ref this._Branch, value); }



        private string _Number;
        public virtual string Number { get => base.GetProperty(this._Number); set => base.SetProperty(ref this._Number, value); }

        private string _IBAN;
        public virtual string IBAN { get => base.GetProperty(this._IBAN); set => base.SetProperty(ref this._IBAN, value); }

        private string _SwiftCode;
        public virtual string SwiftCode { get => base.GetProperty(this._SwiftCode); set => base.SetProperty(ref this._SwiftCode, value); }

        private string _Type;
        public virtual string Type{ get => base.GetProperty(this._Type); set => base.SetProperty(ref this._Type, value); }


        private int _Order;
        public virtual int Order { get => base.GetProperty(this._Order); set => base.SetProperty(ref this._Order, value); }

        private string _Description;
        public virtual string Description { get => base.GetProperty(this._Description); set => base.SetProperty(ref this._Description, value); }

        private int _State;
        public virtual int State { get => base.GetProperty(this._State); set => base.SetProperty(ref this._State, value); }


        private BankBasic _Bank;
        public virtual BankBasic Bank { get => base.GetProperty(this._Bank); set => base.SetProperty(ref this._Bank, value); }
        IBankData IBankAccountData.Bank { get { return this.Bank as IBankData; } set { this.Bank = (BankBasic)value; } }

        private DataItemList _Dataset;
        public virtual DataItemList Dataset { get => base.GetProperty(this._Dataset); set => base.SetProperty(ref this._Dataset, value); }
        IDataItemList<IDataItemData> IBankAccountData.Dataset { get { return this.Dataset as IDataItemList<IDataItemData>; } set { this.Dataset = (DataItemList)value; } }

        public BankAccountBasic()
        {
            this.Dataset = new DataItemList();
        }
    }
}
