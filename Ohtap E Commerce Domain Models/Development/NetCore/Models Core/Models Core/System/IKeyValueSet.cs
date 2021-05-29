using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Core.System
{
    public interface IKeyValueSet<TKey, TValue> : IObjecta
    {
        TKey Key { get; set; }
        TValue Value { get; set; }
    }
}
