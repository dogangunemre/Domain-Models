using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Invoices
{
    public class InvoiceBasic : IInvoiceData
    {
        public virtual string ID { get; set; }
        public virtual string Title { get; set; }
        public virtual int Order { get; set; }
        public virtual string Description { get; set; }
        public virtual int State { get; set; }

        public virtual decimal TotalPrice { get; set; }
        public virtual long Date { get; set; }
    }
}
