using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreSystem = Ohtap.ECommerce.Domain.Models.Core.System;


namespace Ohtap.ECommerce.Domain.Models.Objects.Discounts
{
    public interface IDiscountDataList : CoreSystem.ILista<IDiscountData>
    {
    }
}
