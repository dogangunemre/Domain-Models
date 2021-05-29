using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.PackageOptions
{
    public class PackageOptionBasic :Objecta, IPackageOptionData
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


        private string _Value;
        public virtual string Value { get => base.GetProperty(this._Value); set => base.SetProperty(ref this._Value, value); }

        private Option _Option;
        public virtual Option Option { get => base.GetProperty(this._Option); set => base.SetProperty(ref this._Option, value); }
        IOptionData IPackageOptionData.Option { get { return this.Option as IOptionData; } set { this.Option = (Option)value; } }


        private DataItemList _Dataset;
        public virtual DataItemList Dataset { get => base.GetProperty(this._Dataset); set => base.SetProperty(ref this._Dataset, value); }
        IDataItemList<IDataItemData> IPackageOptionData.Dataset { get { return this.Dataset as IDataItemList<IDataItemData>; } set { this.Dataset = (DataItemList)value; } }
        

        public PackageOptionBasic()
        {
            this.Dataset = new DataItemList();
        }
    }
}
