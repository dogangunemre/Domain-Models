using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Packages
{
    public interface IPackage : IPackageData
    {
        PackageDetails.IPackageDetailDataList Details { set; get; }
        Categories.ICategoryDataList Categories { get; set; }
        Taxes.ITaxData Tax { get; set; }
        Files.IFileDataList Photos { get; set; }
        PackageOptions.IPackageOptionDataList Options { get; set; }
        PackageLabels.IPackageLabelDataList Labels { get; set; }
        Feedbacks.IFeedbackDataList Feedbacks { get; set; }
        PackageAttributes .IPackageAttributeDataList Attributes { get; set; }
        Discounts.IDiscountData Discount { get; set; }
        Warehouses.IWarehouseDataList Warehouses { get; set; }
        PackageSpecifications.IPackageSpecificationDataList Specifications { get; set; }


    }
}
