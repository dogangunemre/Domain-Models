using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.LabelDetails;
using Ohtap.ECommerce.Domain.Models.Objects.Languages;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.LabelDetails
{
    public class LabelDetail : LabelDetailBasic, ILabelDetail
    {
        ILanguage ILabelDetail.Language { get; set; }
    }
}
