using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Serializable.Objects.PromotionDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Files;
using Ohtap.ECommerce.Domain.Models.Objects.Packages;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.PromotionDetails;
using Ohtap.ECommerce.Domain.Models.Objects.Promotions;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Promotions
{
    public class Promotion : PromotionBasic, IPromotion
    {
        public IFileData Photo { get; set; }
        public IPackageDataList Packages { get; set; }

        public IProductDataList Products { get; set; }
        IPromotionDetailDataList IPromotion.Details { get; set; }
    }
}
