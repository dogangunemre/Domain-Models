using Ohtap.ECommerce.Domain.Models.Objects.Invoices;
using Ohtap.ECommerce.Domain.Models.Objects.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Orders
{
    public class OrderBasic : IOrderData
    {
        public virtual string ID { get; set; }
        public virtual string Title { get; set; }
        public virtual string Name { get; set; }
        public virtual int Order { get; set; }
        public virtual string Description { get; set; }
        public virtual int State { get; set; }
        public virtual decimal TotalPrice { get; set; }
        public virtual IStoreData Store { get; set; }
        public virtual string Note { get; set; }
        public virtual IInvoiceData InvoiceAddress { get; set; }
        public virtual string DeliveryAddress { get; set; }
    }
}
