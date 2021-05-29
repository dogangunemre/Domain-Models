using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Settings
{
    public interface ISettingList<T> : ISettingDataList<T>
        where T: ISettingData
    {
    }
}
