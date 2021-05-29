using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Languages;

namespace Ohtap.ECommerce.Domain.Models.Objects.AttributeDetails
{
    public interface IAttributeDetail : IAttributeDetailData
    {
      ILanguage Language { get; set; }
    }
}
