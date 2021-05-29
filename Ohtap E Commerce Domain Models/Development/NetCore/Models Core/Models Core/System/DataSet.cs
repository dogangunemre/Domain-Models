using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Core.System
{
    public class DataSet : KeyValueSet<string, object>, IDataSet
    {
        public DataSet()
        {

        }
        public DataSet(string Key, object Value) : base(Key, Value)
        {
        }
    }
}
