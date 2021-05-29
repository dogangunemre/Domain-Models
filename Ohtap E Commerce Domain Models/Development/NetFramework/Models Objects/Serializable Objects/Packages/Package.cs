using Ohtap.ECommerce.Domain.Models.Serializable.Objects.PackageDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Categories;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;
using Ohtap.ECommerce.Domain.Models.Objects.Feedbacks;
using Ohtap.ECommerce.Domain.Models.Objects.Files;
using Ohtap.ECommerce.Domain.Models.Objects.PackageAttributes;
using Ohtap.ECommerce.Domain.Models.Objects.PackageDetails;
using Ohtap.ECommerce.Domain.Models.Objects.PackageLabels;
using Ohtap.ECommerce.Domain.Models.Objects.PackageOptions;
using Ohtap.ECommerce.Domain.Models.Objects.Packages;
using Ohtap.ECommerce.Domain.Models.Objects.PackageSpecifications;
using Ohtap.ECommerce.Domain.Models.Objects.Taxes;
using Ohtap.ECommerce.Domain.Models.Objects.Warehouses;


namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Packages
{
    public class Package : PackageBasic, IPackage
    {
        public ICategoryDataList Categories { get; set; }
        public ITaxData Tax { get; set; }
        public IFileDataList Photos { get; set; }
        public IPackageOptionDataList Options { get; set; }
        public IPackageLabelDataList Labels { get; set; }
        public IFeedbackDataList Feedbacks { get; set; }
        public IPackageAttributeDataList Attributes { get; set; }
        public IDiscountData Discount { get; set; }
        public IWarehouseDataList Warehouses { get; set; }
        public IPackageSpecificationDataList Specifications { get; set; }
        IPackageDetailDataList IPackage.Details { get; set; }
    }
}
