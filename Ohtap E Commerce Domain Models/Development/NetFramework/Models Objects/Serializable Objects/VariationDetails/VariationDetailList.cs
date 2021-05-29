using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.VariationDetails;
using CoreSystem = Ohtap.ECommerce.Domain.Models.Core.System;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.VariationDetails
{
    public class VariationDetailList : CoreSystem.Lista<IVariationDetailData>, IVariationDetailList
    {
    }
}
