using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Objects.Addresses;
using Ohtap.ECommerce.Domain.Models.Objects.Cargos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.Shippings
{
    public interface IShippingData :  CoreObject.IObjectID, CoreObject.IObjectCode, CoreObject.IObjectName, CoreObject.IObjectOrder, CoreObject.IObjectDescription, CoreObject.IObjectState, IShippingPhone, IShippingEMail, IShippingFax
    {
        IAddressData Address { get; set; }
        ICargoData Cargo { get; set; }
        IDataItemList<IDataItemData> Dataset { get; set; }

    }
}
