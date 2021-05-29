using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Objects.Measures;
using Ohtap.ECommerce.Domain.Models.Objects.Prices;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.Units;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.Packages
{
    public interface IPackageData :  CoreObject.IObjectID, CoreObject.IObjectCode, CoreObject.IObjectName, CoreObject.IObjectOrder, CoreObject.IObjectDescription, CoreObject.IObjectState, IPackageBarcode, IPackageSKU
    {
        IUnitData Unit { get; set; }
        IPriceDataList<IPriceData> Prices { get; set; }
        IProductDataList<IProductData> Products { get; set; }
        IMeasureDataList<IMeasureData> Measures { get; set; }

        IDataItemList<IDataItemData> Dataset { get; set; }
    }
}
