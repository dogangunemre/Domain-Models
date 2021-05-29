using System;
using Ohtap.ECommerce.Domain.Models.Core.System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Datasets
{
    public class DataItemBasic : KeyValueSet<string, object>, IDataItemData
    {
        public DataItemBasic()
        {

        }
        public DataItemBasic(string Key, object Value) : base(Key, Value)
        {
        }
    }
}
