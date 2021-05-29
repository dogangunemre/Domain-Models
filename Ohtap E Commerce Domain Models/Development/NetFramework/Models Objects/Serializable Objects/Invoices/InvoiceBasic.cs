using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Invoices;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Invoices
{
    public class InvoiceBasic : IInvoiceData
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public int State { get; set; }

        public decimal TotalPrice { get; set; }
        public long Date { get; set; }
    }
}
