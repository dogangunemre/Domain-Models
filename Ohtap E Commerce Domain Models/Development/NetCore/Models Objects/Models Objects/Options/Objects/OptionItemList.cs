using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Options.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Options.Objects
{
    public class OptionItemList<T> : Lista<T>, IOptionItemList<T>
        where T : IOptionIdentity
    {
    }
}
