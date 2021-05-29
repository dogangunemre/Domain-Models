using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Languages;
using Ohtap.ECommerce.Domain.Models.Objects.SpecificationDetails;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.SpecificationDetails
{
    public class SpecificationDetail : SpecificationDetailBasic, ISpecificationDetail
    {
        ILanguage ISpecificationDetail.Language { get; set; }
    }
}
