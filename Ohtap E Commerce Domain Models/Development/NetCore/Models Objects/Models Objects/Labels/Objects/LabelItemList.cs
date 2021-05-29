using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Labels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Labels.Objects
{
    public class LabelItemList<T> : Lista<T>, ILabelItemList<T>
        where T : ILabelIdentity
    {
    }
}
