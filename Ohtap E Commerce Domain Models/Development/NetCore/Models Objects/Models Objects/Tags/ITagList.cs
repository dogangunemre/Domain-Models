using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Tags
{
    public interface ITagList <T>: ITagDataList<T>
        where T : ITagData
    {
    }
}
