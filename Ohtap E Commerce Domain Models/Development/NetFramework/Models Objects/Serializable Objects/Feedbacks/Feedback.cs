using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Customers;
using Ohtap.ECommerce.Domain.Models.Objects.Feedbacks;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Feedbacks
{
    public class Feedback : FeedbackBasic, IFeedback
    {
        public ICustomerData Customer { get; set; }
    }
}
