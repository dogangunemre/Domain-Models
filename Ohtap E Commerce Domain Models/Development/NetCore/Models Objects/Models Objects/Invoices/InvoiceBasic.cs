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
using Ohtap.ECommerce.Domain.Models.Core.System;

namespace Ohtap.ECommerce.Domain.Models.Objects.Invoices
{
    public class InvoiceBasic : Objecta, IInvoiceData
    {
        private string _ID;
        public virtual string ID { get => base.GetProperty(this._ID); set => base.SetProperty(ref this._ID, value); }

        private string _Code;
        public virtual string Code { get => base.GetProperty(this._Code); set => base.SetProperty(ref this._Code, value); }

       

        private int _Order;
        public virtual int Order { get => base.GetProperty(this._Order); set => base.SetProperty(ref this._Order, value); }

        private string _Description;
        public virtual string Description { get => base.GetProperty(this._Description); set => base.SetProperty(ref this._Description, value); }

        private int _State;
        public virtual int State { get => base.GetProperty(this._State); set => base.SetProperty(ref this._State, value); }

        private decimal _TotalPrice;
        public virtual decimal TotalPrice { get => base.GetProperty(this._TotalPrice); set => base.SetProperty(ref this._TotalPrice, value); }

        private long _Date;
        public virtual long Date { get => base.GetProperty(this._Date); set => base.SetProperty(ref this._Date, value); }

        private OrderBasic _InvoiceOrder;
        public virtual OrderBasic InvoiceOrder { get => base.GetProperty(this._InvoiceOrder); set => base.SetProperty(ref this._InvoiceOrder, value); }

        private CustomerBasic _Customer;
        public CustomerBasic Customer  { get => base.GetProperty(this._Customer); set => base.SetProperty(ref this._Customer, value); }

        private StoreBasic _Store;
        public StoreBasic Store { get => base.GetProperty(this._Store); set => base.SetProperty(ref this._Store, value); }

        private DiscountList _Discounts;
        public DiscountList Discounts { get => base.GetProperty(this._Discounts); set => base.SetProperty(ref this._Discounts, value); }


        private List<OrderItemBasic> _InvoiceItems;
        public List<OrderItemBasic> InvoiceItems { get => base.GetProperty(this._InvoiceItems); set => base.SetProperty(ref this._InvoiceItems, value); }

        private AddressBasic _DeliveryAddress;
        public AddressBasic DeliveryAddress { get => base.GetProperty(this._DeliveryAddress); set => base.SetProperty(ref this._DeliveryAddress, value); }

        private AddressBasic _InvoiceAddress;
        public AddressBasic InvoiceAddress { get => base.GetProperty(this._InvoiceAddress); set => base.SetProperty(ref this._InvoiceAddress, value); }


        private string _Name;
        public virtual string Name { get => base.GetProperty(this._Name); set => base.SetProperty(ref this._Name, value); }

        private decimal _SubTotal;
        public virtual decimal SubTotal { get => base.GetProperty(this._SubTotal); set => base.SetProperty(ref this._SubTotal, value); }

        private decimal _DiscountTotal;
        public virtual decimal DiscountTotal { get => base.GetProperty(this._DiscountTotal); set => base.SetProperty(ref this._DiscountTotal, value); }

        private decimal _GrandTotal;
        public virtual decimal GrandTotal { get => base.GetProperty(this._GrandTotal); set => base.SetProperty(ref this._GrandTotal, value); }

        private decimal _Paid;
        public virtual decimal Paid { get => base.GetProperty(this._Paid); set => base.SetProperty(ref this._Paid, value); }

        private decimal _Due;
        public virtual decimal Due { get => base.GetProperty(this._Due); set => base.SetProperty(ref this._Due, value); }

        private DataItemList _Dataset;
        public virtual DataItemList Dataset { get => base.GetProperty(this._Dataset); set => base.SetProperty(ref this._Dataset, value); }
        IDataItemList<IDataItemData> IInvoiceData.Dataset { get { return this.Dataset as IDataItemList<IDataItemData>; } set { this.Dataset = (DataItemList)value; } }

        public InvoiceBasic()
        {
            this.Dataset = new DataItemList();
        }

    }
}
