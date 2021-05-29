using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.OptionDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Options
{
    public class Option : OptionBasic, IOption
    {
        
        IOptionDetailDataList IOption.Details { get; set; }
    }
}
