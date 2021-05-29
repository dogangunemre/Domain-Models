using Ohtap.ECommerce.Domain.Models.Objects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Invoices
{
    public class Invoice : InvoiceBasic, IInvoice
    {
        public virtual Customers.ICustomerData Customer { get; set; }
        public virtual Files.IFileData Photo { get; set; }
    }
}
