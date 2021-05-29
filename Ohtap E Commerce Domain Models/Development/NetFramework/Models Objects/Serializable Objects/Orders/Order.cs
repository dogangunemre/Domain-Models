using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Campaigns;
using Ohtap.ECommerce.Domain.Models.Objects.Coupons;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;
using Ohtap.ECommerce.Domain.Models.Objects.Invoices;
using Ohtap.ECommerce.Domain.Models.Objects.OrderItems;
using Ohtap.ECommerce.Domain.Models.Objects.Orders;
using Ohtap.ECommerce.Domain.Models.Objects.Packages;
using Ohtap.ECommerce.Domain.Models.Objects.Payments;
using Ohtap.ECommerce.Domain.Models.Objects.Shippings;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Orders
{
    public class Order : OrderBasic, IOrder
    {
        public IPaymentDataList Payments { get; set; }
        public IDiscountDataList Discounts { get; set; }
        public IPackageDataList Packages { get; set; }
        public IOrderItemDataList Items { get; set; }
        public ICampaignDataList Campaigns { get; set; }
        public ICouponDataList Coupons { get; set; }
        public IInvoiceData Invoice { get; set; }
        public IShippingDataList Shippings { get; set; }
    }
}
