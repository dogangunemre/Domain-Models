using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Customers;
using Ohtap.ECommerce.Domain.Models.Objects.Files;
using Ohtap.ECommerce.Domain.Models.Objects.Invoices;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Invoices
{
    public class Invoice : InvoiceBasic, IInvoice
    {
        public ICustomerData Customer { get; set; }
        public IFileData Photo { get; set; }
    }
}
