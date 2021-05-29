using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Taxes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Taxes.Objects
{
    public class TaxItemList<T> : Lista<T>, ITaxItemList<T>
        where T : ITaxIdentity
    {
    }
}
