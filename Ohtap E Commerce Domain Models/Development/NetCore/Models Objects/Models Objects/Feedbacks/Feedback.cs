using Ohtap.ECommerce.Domain.Models.Objects.Customers;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Feedbacks
{
    public class Feedback : FeedbackBasic, IFeedback
    {
        private Customer _Customer;
        public virtual Customer Customer { get => base.GetProperty(this._Customer); set => base.SetProperty(ref this._Customer, value); }
        ICustomerData IFeedback.Customer { get { return this.Customer as ICustomerData; } set { this.Customer = (Customer)value; } }
    }
}
