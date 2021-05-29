using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Core.System;

using Ohtap.ECommerce.Domain.Models.Objects.Packages;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.Prices;
using Ohtap.ECommerce.Domain.Models.Objects.OrderItemStatuses;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.OrderItems
{
    public class OrderItemBasic : Objecta, IOrderItemData
    {

        private string _ID;
        public virtual string ID { get => base.GetProperty(this._ID); set => base.SetProperty(ref this._ID, value); }

        private string _Name;
        public virtual string Name { get => base.GetProperty(this._Name); set => base.SetProperty(ref this._Name, value); }

        private int _Order;
        public virtual int Order { get => base.GetProperty(this._Order); set => base.SetProperty(ref this._Order, value); }

        private string _Description;
        public virtual string Description { get => base.GetProperty(this._Description); set => base.SetProperty(ref this._Description, value); }

        private int _State;
        public virtual int State { get => base.GetProperty(this._State); set => base.SetProperty(ref this._State, value); }


        private int _Amount;
        public virtual int Amount { get => base.GetProperty(this._Amount); set => base.SetProperty(ref this._Amount, value); }

        private OrderItemTypes _ItemType;
        public virtual OrderItemTypes ItemType { get => base.GetProperty(this._ItemType); set => base.SetProperty(ref this._ItemType, value); }



        private ProductBasic _Product;
        public virtual ProductBasic Product { get => base.GetProperty(this._Product); set => base.SetProperty(ref this._Product, value); }
        IProductData IOrderItemData.Product { get { return this.Product as IProductData; } set { this.Product = (ProductBasic)value; } }




        private OrderItemStatusBasic _OrderItemStatus;
        public virtual OrderItemStatusBasic OrderItemStatus { get => base.GetProperty(this._OrderItemStatus); set => base.SetProperty(ref this._OrderItemStatus, value); }

        private Package _Package;
        public virtual Package Package { get => base.GetProperty(this._Package); set => base.SetProperty(ref this._Package, value); }
        IPackageData IOrderItemData.Package { get { return this.Package as IPackageData; } set { this.Package = (Package)value; } }


        private Price _Price;
        public virtual Price Price { get => base.GetProperty(this._Price); set => base.SetProperty(ref this._Price, value); }
        IPriceData IOrderItemData.Price { get { return this.Price as IPriceData; } set { this.Price = (Price)value; } }

        private DataItemList _Dataset;
        public virtual DataItemList Dataset { get => base.GetProperty(this._Dataset); set => base.SetProperty(ref this._Dataset, value); }
        IDataItemList<IDataItemData> IOrderItemData.Dataset { get { return this.Dataset as IDataItemList<IDataItemData>; } set { this.Dataset = (DataItemList)value; } }

        public OrderItemBasic()
        {
            this.Dataset = new DataItemList();
        }

    }
}
