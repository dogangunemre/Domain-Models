using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;
using Ohtap.ECommerce.Domain.Models.Objects.Promotions;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Promotions
{
    public class PromotionBasic : IPromotionData
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public long EndDate { get; set; }
        public long StartDate { get; set; }
        public IDiscountData Discount { get; set; }
    }
}
