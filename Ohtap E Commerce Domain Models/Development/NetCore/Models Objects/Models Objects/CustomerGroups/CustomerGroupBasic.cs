using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Core.System;

using Ohtap.ECommerce.Domain.Models.Objects.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.CustomerGroups
{
    public class CustomerGroupBasic :Objecta, ICustomerGroupData
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


        private File _Photo;
        public virtual File Photo { get => base.GetProperty(this._Photo); set => base.SetProperty(ref this._Photo, value); }
        IFileData ICustomerGroupData.Photo { get { return this.Photo as Files.IFileData; } set { this.Photo = (Files.File)value; } }

        private CustomerGroup _Parent;
        public virtual CustomerGroup Parent { get => base.GetProperty(this._Parent); set => base.SetProperty(ref this._Parent, value); }
        ICustomerGroup ICustomerGroupData.Parent { get { return this.Parent as ICustomerGroup; } set { this.Parent = (CustomerGroup)value; } }

        private DataItemList _Dataset;
        public virtual DataItemList Dataset { get => base.GetProperty(this._Dataset); set => base.SetProperty(ref this._Dataset, value); }
        IDataItemList<IDataItemData> ICustomerGroupData.Dataset { get { return this.Dataset as IDataItemList<IDataItemData>; } set { this.Dataset = (DataItemList)value; } }

        public CustomerGroupBasic()
        {
            this.Dataset = new DataItemList();
        }
    }
}
