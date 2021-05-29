using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Addresses.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Addresses.Objects
{
    public class AddressItemList<T> : Lista<T>, IAddressItemList<T>
        where T : IAddressIdentity
    {
    }
}
