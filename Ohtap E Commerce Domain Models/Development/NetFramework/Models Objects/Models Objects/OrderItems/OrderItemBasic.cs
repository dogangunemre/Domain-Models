using Ohtap.ECommerce.Domain.Models.Objects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.OrderItems
{
    public class OrderItemBasic : IOrderItemData
    {
        public virtual string ID { get; set; }
        public virtual int Order { get; set; }
        public virtual string Description { get; set; }
        public virtual int State { get; set; }
        public virtual int Amount { get; set; }
        public virtual OrderItemTypes ItemType { get; set; }
        public virtual IProductData Product { get; set; }
        public virtual Packages.IPackageData Package { get; set; }
    }
}
