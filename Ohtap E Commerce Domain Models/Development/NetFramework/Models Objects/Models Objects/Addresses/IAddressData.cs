using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.Addresses
{
    public interface IAddressData :  CoreObject.IObjectID,CoreObject.IObjectTitle, CoreObject.IObjectOrder, CoreObject.IObjectDescription, CoreObject.IObjectState, IAddressFullAddress, IAddressPostCode, IAddressCountry, IAddressCity
    {

    }
}
