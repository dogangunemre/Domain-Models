using Ohtap.ECommerce.Domain.Models.Objects.OptionDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Options
{
    public interface IOption : IOptionData
    {
        IOptionDetailDataList<IOptionDetailData> Details { set; get; }
      
    }
}
