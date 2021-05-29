using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.PackageAttributes
{
    public class PackageAttributeBasic :Objecta, IPackageAttributeData
    {
        private string _ID;
        public virtual string ID { get => base.GetProperty(this._ID); set => base.SetProperty(ref this._ID, value); }
        private int _Order;
        public virtual int Order { get => base.GetProperty(this._Order); set => base.SetProperty(ref this._Order, value); }

        private string _Description;
        public virtual string Description { get => base.GetProperty(this._Description); set => base.SetProperty(ref this._Description, value); }

        private int _State;
        public virtual int State { get => base.GetProperty(this._State); set => base.SetProperty(ref this._State, value); }

        private string _Value;
        public virtual string Value { get => base.GetProperty(this._Value); set => base.SetProperty(ref this._Value, value); }

        private Attribute _Attribute;
        public virtual Attribute Attribute { get => base.GetProperty(this._Attribute); set => base.SetProperty(ref this._Attribute, value); }
        IAttributeData IPackageAttributeData.Attribute { get { return this.Attribute as IAttributeData; } set { this.Attribute = (Attribute)value; } }

        private DataItemList _Dataset;
        public virtual DataItemList Dataset { get => base.GetProperty(this._Dataset); set => base.SetProperty(ref this._Dataset, value); }
        IDataItemList<IDataItemData> IPackageAttributeData.Dataset { get { return this.Dataset as IDataItemList<IDataItemData>; } set { this.Dataset = (DataItemList)value; } }

        public PackageAttributeBasic()
        {
            this.Dataset = new DataItemList();
        }
    }
}
