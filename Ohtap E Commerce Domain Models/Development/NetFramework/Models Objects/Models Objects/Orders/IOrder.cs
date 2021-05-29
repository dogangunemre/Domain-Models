using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Orders
{
    public interface IOrder : IOrderData
    {
        Payments.IPaymentDataList Payments { get; set; }
        Discounts.IDiscountDataList Discounts { get; set; }
        Packages.IPackageDataList Packages { get; set; }

        OrderItems.IOrderItemDataList Items { get; set; }
        Campaigns.ICampaignDataList Campaigns { get; set; }

        Coupons.ICouponDataList Coupons { get; set; }
        Shippings.IShippingDataList Shippings { get; set; }

        public string DeliveryAddress { get; set; }

        Invoices.IInvoiceData InvoiceAddress { get; set; }



    }
}
