using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Core.System
{
    public interface ILista<T> : IObjecta, IEnumerable<T>, IList<T>, IReadOnlyList<T>, INotifyCollectionChanged, INotifyPropertyChanged
    {
    }
}
