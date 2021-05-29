using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Manufacturers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Manufacturers.Objects
{
    public class ManufacturerItemList<T> : Lista<T>, IManufacturerItemList<T>
        where T : IManufacturerIdentity
    {
    }
}
