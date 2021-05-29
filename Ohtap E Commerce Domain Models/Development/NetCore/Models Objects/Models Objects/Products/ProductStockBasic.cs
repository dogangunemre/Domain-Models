using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Objects.Units;
using Ohtap.ECommerce.Domain.Models.Objects.Warehouses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Products
{
    public class ProductStockBasic : Objecta,IProductStockData
    {
        private WarehouseBasic _Warehouse;
        public WarehouseBasic Warehouse { get => base.GetProperty(this._Warehouse); set => base.SetProperty(ref this._Warehouse, value); }
        private UnitBasic _Unit;
        public UnitBasic Unit { get => base.GetProperty(this._Unit); set => base.SetProperty(ref this._Unit, value); }
        private decimal _Amount;
        public decimal Amount { get => base.GetProperty(this._Amount); set => base.SetProperty(ref this._Amount, value); }
        private string _ID;
        public virtual string ID { get => base.GetProperty(this._ID); set => base.SetProperty(ref this._ID, value); }

        private string _Code;
        public virtual string Code { get => base.GetProperty(this._Code); set => base.SetProperty(ref this._Code, value); }

        private string _Name;
        public virtual string Name { get => base.GetProperty(this._Name); set => base.SetProperty(ref this._Name, value); }

        private int _Order;
        public virtual int Order { get => base.GetProperty(this._Order); set => base.SetProperty(ref this._Order, value); }

        private string _Description;
        public virtual string Description { get => base.GetProperty(this._Description); set => base.SetProperty(ref this._Description, value); }

        private int _State;
        public virtual int State { get => base.GetProperty(this._State); set => base.SetProperty(ref this._State, value); }

        private DataItemList _Dataset;
        public virtual DataItemList Dataset { get => base.GetProperty(this._Dataset); set => base.SetProperty(ref this._Dataset, value); }
        IDataItemList<IDataItemData> IProductStockData.Dataset { get { return this.Dataset as IDataItemList<IDataItemData>; } set { this.Dataset = (DataItemList)value; } }

        public ProductStockBasic()
        {
            this.Dataset = new DataItemList();
        }
    }

}