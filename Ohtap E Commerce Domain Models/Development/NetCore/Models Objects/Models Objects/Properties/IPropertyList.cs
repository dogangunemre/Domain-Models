using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Properties
{
    public interface IPropertyList <T>: IPropertyDataList<T>
        where T : IPropertyData
    {
    }
}
