using Ohtap.ECommerce.Domain.Models.Objects.Packages;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Relations
{
    public interface IRelation : IRelationData
    {
        IProductDataList<IProductData> Products { get; set; }

        IPackageDataList<IPackageData> Packages { get; set; }

    }
}
