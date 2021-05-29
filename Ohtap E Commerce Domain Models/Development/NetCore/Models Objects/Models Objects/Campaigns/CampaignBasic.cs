using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Objects.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Campaigns
{
    public class CampaignBasic :Objecta, ICampaignData
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

        private long _StartDate;
        public virtual long StartDate { get => base.GetProperty(this._StartDate); set => base.SetProperty(ref this._StartDate, value); }


        private long _EndDate;
        public virtual long EndDate { get => base.GetProperty(this._EndDate); set => base.SetProperty(ref this._EndDate, value); }


        private FileList _Photos;
        public virtual FileList Photos { get => base.GetProperty(this._Photos); set => base.SetProperty(ref this._Photos, value); }
        IFileDataList<IFileData> ICampaignData.Photos { get { return this.Photos as IFileDataList<IFileData>; } set { this.Photos = (FileList)value; } }


        private DataItemList _Dataset;
        public virtual DataItemList Dataset { get => base.GetProperty(this._Dataset); set => base.SetProperty(ref this._Dataset, value); }
        IDataItemList<IDataItemData> ICampaignData.Dataset { get { return this.Dataset as IDataItemList<IDataItemData>; } set { this.Dataset = (DataItemList)value; } }

        public CampaignBasic()
        {
            this.Dataset = new DataItemList();
        }
    }
}
