using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.Banks
{
    public interface IBankData :  CoreObject.IObjectID, CoreObject.IObjectCode, CoreObject.IObjectName, CoreObject.IObjectOrder, CoreObject.IObjectDescription, CoreObject.IObjectState, IBankPhone, IBankEMail, IBankFax
    {
        IDataItemList<IDataItemData> Dataset { get; set; }
    }
}
