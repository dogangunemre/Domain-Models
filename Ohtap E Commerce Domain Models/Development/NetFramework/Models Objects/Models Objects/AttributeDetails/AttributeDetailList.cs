using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreSystem = Ohtap.ECommerce.Domain.Models.Core.System;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.AttributeDetails
{
    public class AttributeDetailList : CoreSystem.Lista<IAttributeDetailData>, IAttributeDetailList
    {
    }
}
