using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Datasets
{
    public interface IDataItemList<T> : IDataItemDataList<T>
        where T : IDataItemData
    {
        object this[string Key] { get; set; }
    }
}
