using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreSystem = Ohtap.ECommerce.Domain.Models.Core.System;

namespace Ohtap.ECommerce.Domain.Models.Objects.Datasets
{
    public class DataItemList : CoreSystem.Lista<DataItemBasic>, IDataItemList<DataItemBasic>
    {
        public object this[string Key]
        {
            get
            {
                object result = null;

                DataItemBasic item = this.FirstOrDefault(o => o.Key == Key);
                if(item != null)
                {
                    result = item.Value;
                }

                return result;
            }
            set
            {
                DataItemBasic item = this.FirstOrDefault(o => o.Key == Key);
                if(item == null)
                {
                    this.Add(new DataItemBasic(Key, value));
                }
                else
                {
                    item.Value = value;
                }
            }
        }
        public DataItemList()
        {
        }
    }
}