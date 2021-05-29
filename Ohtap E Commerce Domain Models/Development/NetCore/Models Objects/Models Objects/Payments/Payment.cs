using Ohtap.ECommerce.Domain.Models.Objects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using Ohtap.ECommerce.Domain.Models.Objects.Customers;
using Ohtap.ECommerce.Domain.Models.Objects.Banks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Payments
{
    public class Payment : PaymentBasic, IPayment
    {
        private Bank _Bank;
        public virtual Bank Bank { get => base.GetProperty(this._Bank); set => base.SetProperty(ref this._Bank, value); }
        IBankData IPayment.Bank { get { return this.Bank as IBankData; } set { this.Bank = (Bank)value; } }


        private Customer _Customer;
        public virtual Customer Customer { get => base.GetProperty(this._Customer); set => base.SetProperty(ref this._Customer, value); }
        ICustomerData IPayment.Customer { get { return this.Customer as ICustomerData; } set { this.Customer = (Customer)value; } }

    }
}
