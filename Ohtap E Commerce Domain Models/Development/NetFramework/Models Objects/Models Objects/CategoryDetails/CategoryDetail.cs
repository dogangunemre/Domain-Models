using Ohtap.ECommerce.Domain.Models.Objects.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.CategoryDetails
{
    public  class CategoryDetail : CategoryDetailBasic, ICategoryDetail
    {
        ILanguage ICategoryDetail.Language { get; set; }
    }
}
