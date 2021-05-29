using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.PackageDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.PackageAttributeDetails;

namespace Ohtap.ECommerce.Domain.Models.Objects.PackageAttributes
{
    public class PackageAttribute : PackageAttributeBasic, IPackageAttribute
    {
        private PackageAttributeDetailList _Details;
        public virtual PackageAttributeDetailList Details { get => base.GetProperty(this._Details); set => base.SetProperty(ref this._Details, value); }
        IPackageAttributeDetailDataList<IPackageAttributeDetailData> IPackageAttribute.Details { get { return this.Details as IPackageAttributeDetailDataList<IPackageAttributeDetailData>; } set { this.Details = (PackageAttributeDetailList)value; } }
    }
}
