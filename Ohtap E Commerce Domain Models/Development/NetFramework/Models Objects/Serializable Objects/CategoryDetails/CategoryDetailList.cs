using Ohtap.ECommerce.Domain.Models.Objects.CategoryDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreSystem = Ohtap.ECommerce.Domain.Models.Core.System;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.CategoryDetails
{
    public class CategoryDetailList : CoreSystem.Lista<ICategoryDetailData>, ICategoryDetailList
    {
    }
}
