using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Core.System
{
    public interface IDataSetList<T> : ILista<T>
        where T : IDataSet
    {
        object this[string Key] { get; set; }
    }
    public interface IDataSetList : IDataSetList<IDataSet>
    {
    }
}
