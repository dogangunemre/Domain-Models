using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Labels
{
    public interface ILabel : ILabelData
    {
        LabelDetails.ILabelDetailDataList Details { set; get; }
      
    }
}
