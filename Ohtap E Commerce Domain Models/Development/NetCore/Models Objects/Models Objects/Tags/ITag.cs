using Ohtap.ECommerce.Domain.Models.Objects.TagDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Tags
{
    public interface ITag : ITagData
    {
        ITagDetailDataList<ITagDetailData> Details { set; get; }
      
    }
}
