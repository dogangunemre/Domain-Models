using Ohtap.ECommerce.Domain.Models.Objects.Measures;
using Ohtap.ECommerce.Domain.Models.Objects.Prices;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Packages
{
    public class PackageBasic : IPackageData
    {
        public virtual string ID { get; set; }
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual int Order { get; set; }
        public virtual string Description { get; set; }
        public virtual int State { get; set; }
        public virtual string Barcode { get; set; }
        public virtual IUnitData Unit { get; set; }
        public virtual IPriceDataList Prices { get; set; }
        public virtual IProductDataList Products { get; set; }
        public virtual IMeasureDataList Measures { get; set; }
        public virtual string SKU { get; set; }
    }
}
