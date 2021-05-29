
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.Campaigns
{
    public interface ICampaignData : CoreObject.IObjectID, CoreObject.IObjectOrder, CoreObject.IObjectState, CoreObject.IObjectCode,CoreObject.IObjectDescription, CoreObject.IObjectName, ICampaignPhotos, ICampaignStartDate, ICampaignEndDate
    {
    }
}
