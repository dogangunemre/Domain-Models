using Ohtap.ECommerce.Domain.Models.Objects.Categories;
using Ohtap.ECommerce.Domain.Models.Objects.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Categories
{
    public class CategoryBasic : ICategoryData
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public ICategoryData Parent { get; set; }
        public IFileData Photo { get; set; }
    }
}
