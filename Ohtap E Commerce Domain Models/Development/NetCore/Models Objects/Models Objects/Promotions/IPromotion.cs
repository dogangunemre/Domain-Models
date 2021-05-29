using Ohtap.ECommerce.Domain.Models.Objects.Files;
using Ohtap.ECommerce.Domain.Models.Objects.Packages;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.PromotionDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Promotions
{
    public interface IPromotion : IPromotionData
    {
        IFileData Photo { get; set; }
        IPackageDataList<IPackageData> Packages { get; set; }
        IProductDataList<IProductData> Products { get; set; }
        IPromotionDetailDataList<IPromotionDetailData> Details { set; get; }
    }
}
