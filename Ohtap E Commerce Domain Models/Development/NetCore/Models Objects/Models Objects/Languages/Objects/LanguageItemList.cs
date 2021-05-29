using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Languages.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Languages.Objects
{
    public class LanguageItemList<T> : Lista<T>, ILanguageItemList<T>
        where T : ILanguageIdentity
    {
    }
}
