using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Measures;
using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Prices;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Measures;
using Ohtap.ECommerce.Domain.Models.Objects.Packages;
using Ohtap.ECommerce.Domain.Models.Objects.Prices;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.Units;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Packages
{
    public class PackageBasic : IPackageData
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public string Barcode { get; set; }
        public IUnitData Unit { get; set; }
        public IPriceDataList Prices { get; set; }
        public IProductDataList Products { get; set; }
        public IMeasureDataList Measures { get; set; }
        public string SKU { get; set; }
    }
}
