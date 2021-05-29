using Ohtap.ECommerce.Domain.Models.Objects.Packages;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Relations
{
    public class Relation : RelationBasic, IRelation
    {
        public virtual IProductDataList Products { get; set; }
        public virtual IPackageDataList Packages { get; set; }
    }
}
