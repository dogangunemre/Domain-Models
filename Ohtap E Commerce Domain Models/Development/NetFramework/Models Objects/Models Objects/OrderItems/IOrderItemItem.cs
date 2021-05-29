using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.OrderItems
{
    public interface IOrderItemItem
    {
        Products.IProductData Product { get; set; }
        Packages.IPackageData Package { get; set; }

    }
}
