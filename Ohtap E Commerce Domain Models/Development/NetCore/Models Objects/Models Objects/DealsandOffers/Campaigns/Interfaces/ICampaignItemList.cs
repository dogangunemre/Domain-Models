using Ohtap.ECommerce.Domain.Models.Core.Object;
using Ohtap.ECommerce.Domain.Models.Core.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Campaigns.Interfaces
{
    public interface ICampaignItemList<T> : ILista<T>
        where T: ICampaignIdentity
    {
    }
}
