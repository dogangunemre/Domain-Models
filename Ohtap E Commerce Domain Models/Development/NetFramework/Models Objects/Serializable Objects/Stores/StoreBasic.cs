﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Stores;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Stores
{
    public class StoreBasic : IStoreData
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public string Fax { get; set; }
    }
}
