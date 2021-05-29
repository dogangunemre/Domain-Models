using Ohtap.ECommerce.Domain.Models.Core.Object;
using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Campaigns.Interfaces;
using Ohtap.ECommerce.Domain.Models.Objects.Files;
using Ohtap.ECommerce.Domain.Models.Objects.Files.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Campaigns.Objects
{
    public class CampaignExtended : CampaignDetail, ICampaignExtended
    {
        private FileList _Photos;
        public virtual FileList Photos { get => base.GetProperty(this._Photos); set => base.SetProperty(ref this._Photos, value); }
        
    }
}
