using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Invoices;
using Ohtap.ECommerce.Domain.Models.Objects.Orders;
using Ohtap.ECommerce.Domain.Models.Objects.Stores;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Orders
{
    public class OrderBasic : IOrderData
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public decimal TotalPrice { get; set; }
        public IStoreData Store { get; set; }
        public string Note { get; set; }
        public IInvoiceData InvoiceAddress { get; set; }
        public string DeliveryAddress { get; set; }
    }
}
