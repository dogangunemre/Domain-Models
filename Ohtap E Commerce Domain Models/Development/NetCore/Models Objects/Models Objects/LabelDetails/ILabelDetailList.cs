using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.LabelDetails
{
    public interface ILabelDetailList<T> : ILabelDetailDataList<T>
        where T : ILabelDetailData
    {
    }
}
