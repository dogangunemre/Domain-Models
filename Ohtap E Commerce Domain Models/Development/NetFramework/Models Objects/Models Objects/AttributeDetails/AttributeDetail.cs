using Ohtap.ECommerce.Domain.Models.Objects.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.AttributeDetails
{
    public class AttributeDetail : AttributeDetailBasic, IAttributeDetail
    {
        ILanguage IAttributeDetail.Language { get; set; }
    }
}
