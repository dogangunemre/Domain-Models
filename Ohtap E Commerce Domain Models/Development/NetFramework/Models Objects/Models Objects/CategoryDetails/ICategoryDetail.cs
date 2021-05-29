using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Languages;

namespace Ohtap.ECommerce.Domain.Models.Objects.CategoryDetails
{
    public interface ICategoryDetail : ICategoryDetailData
    {
        ILanguage Language { get; set; }
    }
}
