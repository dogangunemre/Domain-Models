using Ohtap.ECommerce.Domain.Models.Serializable.Objects.OptionDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.OptionDetails;
using Ohtap.ECommerce.Domain.Models.Objects.Options;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.Options
{
    public class Option : OptionBasic, IOption
    {
        
        IOptionDetailDataList IOption.Details { get; set; }
    }
}
