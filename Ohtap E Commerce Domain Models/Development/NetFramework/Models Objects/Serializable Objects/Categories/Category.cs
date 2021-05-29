﻿using Ohtap.ECommerce.Domain.Models.Serializable.Objects.CategoryDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.CategoryDetails;
using Ohtap.ECommerce.Domain.Models.Objects.Categories;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Categories
{
    public class Category : CategoryBasic, ICategory
    {
        public ICategoryList Childs { get; set; }
        ICategoryDetailDataList ICategory.Details { get; set; }
    }
}
