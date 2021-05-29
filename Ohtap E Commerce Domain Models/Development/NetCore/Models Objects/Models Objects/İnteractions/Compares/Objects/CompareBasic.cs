using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Compares.Interfaces;
using Ohtap.ECommerce.Domain.Models.Objects.Customers;
using Ohtap.ECommerce.Domain.Models.Objects.Customers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Compares.Objects
{
    public class CompareBasic : CompareInfo, ICompareBasic
    {
        private int _Order;
        public virtual int Order { get => base.GetProperty(this._Order); set => base.SetProperty(ref this._Order, value); }

        private string _Description;
        public virtual string Description { get => base.GetProperty(this._Description); set => base.SetProperty(ref this._Description, value); }

        private int _State;
        public virtual int State { get => base.GetProperty(this._State); set => base.SetProperty(ref this._State, value); }

        private CustomerBasic _Customer;
        public virtual CustomerBasic Customer { get => base.GetProperty(this._Customer); set => base.SetProperty(ref this._Customer, value); }
        ICustomerBasic Interfaces.ICompareBasic.Customer { get { return this.Customer as ICustomerBasic; } set { this.Customer = (CustomerBasic)value; } }
    }
}
