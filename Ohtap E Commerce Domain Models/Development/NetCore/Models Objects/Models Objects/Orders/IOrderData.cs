using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Objects.Addresses;
using Ohtap.ECommerce.Domain.Models.Objects.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Customers;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;
using Ohtap.ECommerce.Domain.Models.Objects.OrderItems;
using Ohtap.ECommerce.Domain.Models.Objects.Payments;
using Ohtap.ECommerce.Domain.Models.Objects.Shippings;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.Orders
{
    public interface IOrderData :  CoreObject.IObjectID, CoreObject.IObjectCode, CoreObject.IObjectName, CoreObject.IObjectOrder, CoreObject.IObjectDescription, CoreObject.IObjectState, IOrderTotalPrice, IOrderNote
    {
      public  CustomerBasic Customer { get; set; }
      public string Status { get; set; }
      public DiscountList Discounts { get; set; }

      public StoreBasic Store { get; set; }
      public List<PaymentBasic> Payments { get; set; }
      public List<ShippingBasic> Shippings { get; set; }

      public List<OrderItemBasic> OrderItems { get; set; }



      public  AddressBasic DeliveryAddress { get; set; }
      public  AddressBasic InvoiceAddress { get; set; }

      public  IDataItemList<IDataItemData> Dataset { get; set; }
    }
}
