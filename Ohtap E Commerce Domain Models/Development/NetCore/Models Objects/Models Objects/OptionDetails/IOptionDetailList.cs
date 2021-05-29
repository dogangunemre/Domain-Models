using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.OptionDetails
{
    public interface IOptionDetailList <T>: IOptionDetailDataList<T>
        where T : IOptionDetailData
    {
    }
}
