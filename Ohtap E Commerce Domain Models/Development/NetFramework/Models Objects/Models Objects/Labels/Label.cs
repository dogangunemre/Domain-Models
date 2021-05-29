using Ohtap.ECommerce.Domain.Models.Objects.LabelDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Labels
{
    public class Label : LabelBasic, ILabel
    {
        
        ILabelDetailDataList ILabel.Details { get; set; }
    }
}
