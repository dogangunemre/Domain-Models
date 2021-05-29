using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.CargoStatuses.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.CargoStatuses.Objects
{
    public class CargoStatusItemList<T> : Lista<T>, ICargoStatusItemList<T>
        where T : ICargoStatusIdentity
    {
    }
}
