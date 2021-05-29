using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.PackageDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Categories;
using Ohtap.ECommerce.Domain.Models.Objects.Taxes;
using Ohtap.ECommerce.Domain.Models.Objects.Files;
using Ohtap.ECommerce.Domain.Models.Objects.PackageOptions;
using Ohtap.ECommerce.Domain.Models.Objects.PackageLabels;
using Ohtap.ECommerce.Domain.Models.Objects.Feedbacks;
using Ohtap.ECommerce.Domain.Models.Objects.PackageAttributes;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;
using Ohtap.ECommerce.Domain.Models.Objects.Warehouses;
using Ohtap.ECommerce.Domain.Models.Objects.PackageSpecifications;

namespace Ohtap.ECommerce.Domain.Models.Objects.Packages
{
    public class Package : PackageBasic, IPackage
    {
        public virtual ICategoryDataList Categories { get; set; }
        public virtual ITaxData Tax { get; set; }
        public virtual IFileDataList Photos { get; set; }
        public virtual IPackageOptionDataList Options { get; set; }
        public virtual IPackageLabelDataList Labels { get; set; }
        public virtual IFeedbackDataList Feedbacks { get; set; }
        public virtual IPackageAttributeDataList Attributes { get; set; }
        public virtual IDiscountData Discount { get; set; }
        public virtual IWarehouseDataList Warehouses { get; set; }
        public virtual IPackageSpecificationDataList Specifications { get; set; }
        IPackageDetailDataList IPackage.Details { get; set; }
    }
}
