using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Settings;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Settings
{
    public class SettingBasic : ISettingData
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
    }
}
