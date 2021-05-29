using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.DiscountDetails
{
    public interface IDiscountDetail : IDiscountDetailData
    {
        Languages.ILanguage Language { get; set; }
    }
}
