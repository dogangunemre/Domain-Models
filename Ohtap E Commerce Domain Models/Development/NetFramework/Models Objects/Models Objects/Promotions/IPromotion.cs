using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Promotions
{
    public interface IPromotion : IPromotionData
    {
        Files.IFileData Photo { get; set; }
        Packages.IPackageDataList Packages { get; set; }
        Products.IProductDataList Products { get; set; }
        PromotionDetails.IPromotionDetailDataList Details { set; get; }
    }
}
