using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Labels;
using Ohtap.ECommerce.Domain.Models.Objects.ProductLabels;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.ProductLabels
{
    public class ProductLabelBasic : IProductLabelData
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public string Value { get; set; }
        public ILabelData Label { get; set; }
    }
}
