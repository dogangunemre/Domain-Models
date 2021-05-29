using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Packages;
using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Packages;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.Relations;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Relations
{
    public class Relation : RelationBasic, IRelation
    {
        public IProductDataList Products { get; set; }
        public IPackageDataList Packages { get; set; }
    }
}
