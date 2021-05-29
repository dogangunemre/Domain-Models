using Ohtap.ECommerce.Domain.Models.Objects.Measures;
using Ohtap.ECommerce.Domain.Models.Objects.Prices;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.Units;
using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Packages
{
    public class PackageBasic :Objecta ,IPackageData
    {
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

        private string _Barcode;
        public virtual string Barcode { get => base.GetProperty(this._Barcode); set => base.SetProperty(ref this._Barcode, value); }

        private string _SKU;
        public virtual string SKU { get => base.GetProperty(this._SKU); set => base.SetProperty(ref this._SKU, value); }


        private Unit _Unit;
        public virtual Unit Unit { get => base.GetProperty(this._Unit); set => base.SetProperty(ref this._Unit, value); }
        IUnitData IPackageData.Unit { get { return this.Unit as IUnitData; } set { this.Unit = (Unit)value; } }

        private PriceList _Prices;
        public virtual PriceList Prices { get => base.GetProperty(this._Prices); set => base.SetProperty(ref this._Prices, value); }
        IPriceDataList<IPriceData> IPackageData.Prices { get { return this.Prices as IPriceDataList<IPriceData>; } set { this.Prices = (PriceList)value; } }

        private ProductList _Products;
        public virtual ProductList Products { get => base.GetProperty(this._Products); set => base.SetProperty(ref this._Products, value); }
        IProductDataList<IProductData> IPackageData.Products { get { return this.Products as IProductDataList<IProductData>; } set { this.Products = (ProductList)value; } }

        private MeasureList _Measures;
        public virtual MeasureList Measures { get => base.GetProperty(this._Measures); set => base.SetProperty(ref this._Measures, value); }
        IMeasureDataList<IMeasureData> IPackageData.Measures { get { return this.Measures as IMeasureDataList<IMeasureData>; } set { this.Measures = (MeasureList)value; } }

        private DataItemList _Dataset;
        public virtual DataItemList Dataset { get => base.GetProperty(this._Dataset); set => base.SetProperty(ref this._Dataset, value); }
        IDataItemList<IDataItemData> IPackageData.Dataset { get { return this.Dataset as IDataItemList<IDataItemData>; } set { this.Dataset = (DataItemList)value; } }

        public PackageBasic()
        {
            this.Dataset = new DataItemList();
        }


    }
}
