using Ohtap.ECommerce.Domain.Models.Objects.Addresses;
using Ohtap.ECommerce.Domain.Models.Objects.Campaigns;
using Ohtap.ECommerce.Domain.Models.Objects.Coupons;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;
using Ohtap.ECommerce.Domain.Models.Objects.Invoices;
using Ohtap.ECommerce.Domain.Models.Objects.OrderItems;
using Ohtap.ECommerce.Domain.Models.Objects.Packages;
using Ohtap.ECommerce.Domain.Models.Objects.Payments;
using Ohtap.ECommerce.Domain.Models.Objects.Shippings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Orders
{
    public interface IOrder : IOrderData
    {
        IPaymentDataList<IPaymentData> Payments { get; set; }
        IDiscountDataList<IDiscountData> Discounts { get; set; }

        IOrderItemDataList<IOrderItemData> Items { get; set; }
        ICampaignDataList<ICampaignData> Campaigns { get; set; }

        ICouponDataList<ICouponData> Coupons { get; set; }

        IInvoiceData Invoice { get; set; }
        IShippingDataList<IShippingData> Shippings { get; set; }





    }
}
