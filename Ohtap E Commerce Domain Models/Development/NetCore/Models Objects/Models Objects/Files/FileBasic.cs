using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Core.System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Files
{
    public class FileBasic :Objecta, IFileData
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

        private decimal _Size;
        public virtual decimal Size { get => base.GetProperty(this._Size); set => base.SetProperty(ref this._Size, value); }


        private string _MIMEType;
        public virtual string MIMEType { get => base.GetProperty(this._MIMEType); set => base.SetProperty(ref this._MIMEType, value); }

        private PathTypes _PathType;
        public virtual PathTypes PathType { get => base.GetProperty(this._PathType); set => base.SetProperty(ref this._PathType, value); }

        private string _Path;
        public virtual string Path { get => base.GetProperty(this._Path); set => base.SetProperty(ref this._Path, value); }

        private DataItemList _Dataset;
        public virtual DataItemList Dataset { get => base.GetProperty(this._Dataset); set => base.SetProperty(ref this._Dataset, value); }
        IDataItemList<IDataItemData> IFileData.Dataset { get { return this.Dataset as IDataItemList<IDataItemData>; } set { this.Dataset = (DataItemList)value; } }

        public FileBasic()
        {
            this.Dataset = new DataItemList();
        }
    }
}
