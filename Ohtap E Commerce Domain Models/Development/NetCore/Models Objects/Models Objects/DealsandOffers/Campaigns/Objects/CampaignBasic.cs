using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Campaigns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Campaigns.Objects
{
    public class CampaignBasic : CampaignInfo, ICampaignBasic
    {
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


        

    }
}
