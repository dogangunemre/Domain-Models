using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.CategoryDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Categories
{
    public class Category : CategoryBasic, ICategory
    {
        public virtual ICategoryList Childs { get; set; }
        ICategoryDetailDataList ICategory.Details { get; set; }
    }
}
