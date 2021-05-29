using Ohtap.ECommerce.Domain.Models.Objects.Invoices;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.Shippings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Orders
{
    public class Order : OrderBasic, IOrder
    {
        public virtual Payments.IPaymentDataList Payments { get; set; }
        public virtual Discounts.IDiscountDataList Discounts { get; set; }
        public virtual Packages.IPackageDataList Packages { get; set; }
        public virtual OrderItems.IOrderItemDataList Items { get; set; }
        public virtual Campaigns.ICampaignDataList Campaigns { get; set; }
        public virtual Coupons.ICouponDataList Coupons { get; set; }
        public virtual IInvoiceData Invoice { get; set; }
        public virtual IShippingDataList Shippings { get; set; }
    }
}
