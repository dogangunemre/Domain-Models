using Ohtap.ECommerce.Domain.Models.Objects.AttributeDetails;
using Ohtap.ECommerce.Domain.Models.Objects.Languages;
using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.AttributeDetails
{
    public class AttributeDetail : AttributeDetailBasic, IAttributeDetail
    {
        ILanguage IAttributeDetail.Language { get; set; }
    }
}
