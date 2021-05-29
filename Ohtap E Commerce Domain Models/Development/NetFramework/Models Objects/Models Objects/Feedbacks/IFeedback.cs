using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Feedbacks
{
    public interface IFeedback : IFeedbackData
    {
        Customers.ICustomerData Customer { get; set; }
    }
}
