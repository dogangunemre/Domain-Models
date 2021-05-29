using Ohtap.ECommerce.Domain.Models.Objects.Customers;
using Ohtap.ECommerce.Domain.Models.Objects.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Invoices
{
    public interface IInvoice : IInvoiceData
    {
        ICustomerData Customer { get; set; }
        IFileData Photo { get; set; }
    }
}
