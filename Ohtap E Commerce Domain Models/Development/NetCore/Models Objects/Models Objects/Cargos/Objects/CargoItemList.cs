using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Cargos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Cargos.Objects
{
    public class CargoItemList<T> : Lista<T>, ICargoItemList<T>
        where T : ICargoIdentity
    {
    }
}
