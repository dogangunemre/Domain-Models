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
        Customers.ICustomerData Customer { get; set; }
        Files.IFileData Photo { get; set; }
    }
}
