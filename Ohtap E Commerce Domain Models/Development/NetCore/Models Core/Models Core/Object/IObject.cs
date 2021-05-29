using Ohtap.ECommerce.Domain.Models.Core.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Core.Object
{
    public interface IObject : IObjectBasic
    {
        IDataSetList DataSet { set; get; }
        ILocalizationList<IObjectBasic> Localizations { set; get; }
    }
}
