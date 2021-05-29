using Ohtap.ECommerce.Domain.Models.Objects.Attributes;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;
using Ohtap.ECommerce.Domain.Models.Objects.Feedbacks;
using Ohtap.ECommerce.Domain.Models.Objects.Files;
using Ohtap.ECommerce.Domain.Models.Objects.Labels;
using Ohtap.ECommerce.Domain.Models.Objects.Options;
using Ohtap.ECommerce.Domain.Models.Objects.PackageDetails;
using Ohtap.ECommerce.Domain.Models.Objects.ProductCategories;
using Ohtap.ECommerce.Domain.Models.Objects.Specifications;
using Ohtap.ECommerce.Domain.Models.Objects.Taxes;
using Ohtap.ECommerce.Domain.Models.Objects.Warehouses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Packages
{
    public interface IPackage : IPackageData
    {
        IProductCategoryDataList<IProductCategoryData> Categories { get; set; }
        ITaxData Tax { get; set; }
        IFileDataList<IFileData> Photos { get; set; }
        IOptionDataList<IOptionData> Options { get; set; }
        ILabelDataList<ILabelData> Labels { get; set; }
        IFeedbackDataList<IFeedbackData> Feedbacks { get; set; }
        IAttributeDataList<IAttributeData> Attributes { get; set; }
        IDiscountDataList<IDiscountData> Discounts { get; set; }
        IWarehouseDataList<IWarehouseData> Warehouses { get; set; }
        ISpecificationDataList<ISpecificationData> Specifications { get; set; }

        IPackageDetailDataList<IPackageDetailData> Details { set; get; }

    }
}
