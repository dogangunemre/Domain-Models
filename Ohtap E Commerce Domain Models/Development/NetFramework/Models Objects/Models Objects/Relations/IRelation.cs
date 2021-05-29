using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Relations
{
    public interface IRelation : IRelationData
    {
        Products.IProductDataList Products { get; set; }
        
        Packages.IPackageDataList Packages { get; set; }

    }
}
