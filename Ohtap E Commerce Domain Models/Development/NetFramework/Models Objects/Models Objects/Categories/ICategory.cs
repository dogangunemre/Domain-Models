using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Categories
{
    public interface ICategory : ICategoryData
    {
        CategoryDetails.ICategoryDetailDataList Details { set; get; }
        Categories.ICategoryList Childs { get; set; }
    }
}
