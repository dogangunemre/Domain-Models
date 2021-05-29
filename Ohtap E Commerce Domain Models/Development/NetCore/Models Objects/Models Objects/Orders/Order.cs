using Ohtap.ECommerce.Domain.Models.Objects.Addresses;
using Ohtap.ECommerce.Domain.Models.Objects.Campaigns;
using Ohtap.ECommerce.Domain.Models.Objects.Coupons;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;
using Ohtap.ECommerce.Domain.Models.Objects.Invoices;
using Ohtap.ECommerce.Domain.Models.Objects.OrderItems;
using Ohtap.ECommerce.Domain.Models.Objects.Packages;
using Ohtap.ECommerce.Domain.Models.Objects.Payments;
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
        private PaymentList _Payments;
        public virtual PaymentList Payments { get => base.GetProperty(this._Payments); set => base.SetProperty(ref this._Payments, value); }
        IPaymentDataList<IPaymentData> IOrder.Payments { get { return this.Payments as IPaymentDataList<IPaymentData>; } set { this.Payments = (PaymentList)value; } }


        private DiscountList _Discounts;
        public virtual DiscountList Discounts { get => base.GetProperty(this._Discounts); set => base.SetProperty(ref this._Discounts, value); }
        IDiscountDataList<IDiscountData> IOrder.Discounts { get { return this.Discounts as IDiscountDataList<IDiscountData>; } set { this.Discounts = (DiscountList)value; } }

        private OrderItemList _Items;
        public virtual OrderItemList Items { get => base.GetProperty(this._Items); set => base.SetProperty(ref this._Items, value); }
        IOrderItemDataList<IOrderItemData> IOrder.Items { get { return this.Items as IOrderItemDataList<IOrderItemData>; } set { this.Items = (OrderItemList)value; } }


        private CampaignList _Campaigns;
        public virtual CampaignList Campaigns { get => base.GetProperty(this._Campaigns); set => base.SetProperty(ref this._Campaigns, value); }
        ICampaignDataList<ICampaignData> IOrder.Campaigns { get { return this.Campaigns as ICampaignDataList<ICampaignData>; } set { this.Campaigns = (CampaignList)value; } }

        private CouponList _Coupons;
        public virtual CouponList Coupons { get => base.GetProperty(this._Coupons); set => base.SetProperty(ref this._Coupons, value); }
        ICouponDataList<ICouponData> IOrder.Coupons { get { return this.Coupons as ICouponDataList<ICouponData>; } set { this.Coupons = (CouponList)value; } }


        private Invoice _Invoice;
        public virtual Invoice Invoice { get => base.GetProperty(this._Invoice); set => base.SetProperty(ref this._Invoice, value); }
        IInvoiceData IOrder.Invoice { get { return this.Invoice as IInvoice; } set { this.Invoice = (Invoice)value; } }

        private ShippingList _Shippings;
        public virtual ShippingList Shippings { get => base.GetProperty(this._Shippings); set => base.SetProperty(ref this._Shippings, value); }
        IShippingDataList<IShippingData> IOrder.Shippings { get { return this.Shippings as IShippingDataList<IShippingData>; } set { this.Shippings = (ShippingList)value; } }

    }
}
