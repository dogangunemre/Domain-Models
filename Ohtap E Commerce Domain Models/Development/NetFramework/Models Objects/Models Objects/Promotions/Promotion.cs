using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.PromotionDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Promotions
{
    public class Promotion : PromotionBasic, IPromotion
    {
        public virtual Files.IFileData Photo { get; set; }
        public virtual Packages.IPackageDataList Packages { get; set; }

        public virtual IProductDataList Products { get; set; }
        IPromotionDetailDataList IPromotion.Details { get; set; }
    }
}
