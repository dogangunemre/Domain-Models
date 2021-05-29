using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.OrderItems;
using Ohtap.ECommerce.Domain.Models.Objects.Packages;
using Ohtap.ECommerce.Domain.Models.Objects.Products;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.OrderItems
{
    public class OrderItemBasic : IOrderItemData
    {
        public string ID { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public int Amount { get; set; }
        public OrderItemTypes ItemType { get; set; }
        public IProductData Product { get; set; }
        public IPackageData Package { get; set; }
    }
}
