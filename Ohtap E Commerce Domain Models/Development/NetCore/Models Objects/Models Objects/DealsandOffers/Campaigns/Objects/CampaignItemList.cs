﻿using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Campaigns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Campaigns.Objects
{
    public class CampaignItemList<T> : Lista<T>, ICampaignItemList<T>
        where T : ICampaignIdentity
    {
    }
}