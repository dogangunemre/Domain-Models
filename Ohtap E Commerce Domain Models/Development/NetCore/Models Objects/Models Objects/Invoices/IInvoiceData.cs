using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Addresses;
using Ohtap.ECommerce.Domain.Models.Objects.Customers;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;
using Ohtap.ECommerce.Domain.Models.Objects.OrderItems;
using Ohtap.ECommerce.Domain.Models.Objects.Orders;
using Ohtap.ECommerce.Domain.Models.Objects.Payments;
using Ohtap.ECommerce.Domain.Models.Objects.Shippings;
using Ohtap.ECommerce.Domain.Models.Objects.Stores;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.Invoices
{
    public interface IInvoiceData :  CoreObject.IObjectID, CoreObject.IObjectCode, CoreObject.IObjectOrder, CoreObject.IObjectDescription, CoreObject.IObjectState,CoreObject.IObjectName, IInvoiceTotalPrice, IInvoiceDate
    {
        public CustomerBasic Customer { get; set; }
        public StoreBasic Store { get; set; }

        public DiscountList Discounts { get; set; }
        public OrderBasic InvoiceOrder { get; set; }
        public List<OrderItemBasic> InvoiceItems { get; set; }
        public AddressBasic DeliveryAddress { get; set; }
        public AddressBasic InvoiceAddress { get; set; }
        IDataItemList<IDataItemData> Dataset { get; set; }
    }
}
