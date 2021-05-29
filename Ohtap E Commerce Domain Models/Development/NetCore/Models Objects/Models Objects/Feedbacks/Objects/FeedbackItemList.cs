using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Feedbacks.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Feedbacks.Objects
{
    public class FeedbackItemList<T> : Lista<T>, IFeedbackItemList<T>
        where T : IFeedbackIdentity
    {
    }
}
