using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Objects.AttributeDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Attributes
{
    public interface IAttribute : IAttributeData
    {
        AttributeDetails.IAttributeDetailDataList<AttributeDetails.IAttributeDetailData> Details { set; get; }

    }
}
