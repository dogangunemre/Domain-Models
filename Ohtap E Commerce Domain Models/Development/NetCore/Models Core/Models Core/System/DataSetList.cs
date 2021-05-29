using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Core.System
{
    public class DataSetList : Lista<DataSet>, IDataSetList<DataSet>
    {
        public object this[string Key]
        {
            get
            {
                object result = null;

                DataSet item = this.FirstOrDefault(o => o.Key == Key);
                if (item != null)
                {
                    result = item.Value;
                }

                return result;
            }
            set
            {
                DataSet item = this.FirstOrDefault(o => o.Key == Key);
                if (item == null)
                {
                    this.Add(new DataSet(Key, value));
                }
                else
                {
                    item.Value = value;
                }
            }
        }
        public DataSetList()
        {
        }
    }
}
