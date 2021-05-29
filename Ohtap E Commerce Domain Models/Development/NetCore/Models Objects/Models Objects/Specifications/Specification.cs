using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.SpecificationDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Specifications
{
    public class Specification : SpecificationBasic, ISpecification
    {
        private SpecificationDetailList _Details;
        public virtual SpecificationDetailList Details { get => base.GetProperty(this._Details); set => base.SetProperty(ref this._Details, value); }
        ISpecificationDetailDataList<ISpecificationDetailData> ISpecification.Details { get { return this.Details as ISpecificationDetailDataList<ISpecificationDetailData>; } set { this.Details = (SpecificationDetailList)value; } }
    }
}
