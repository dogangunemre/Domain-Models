using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Files
{
    public interface IFileList<T> : IFileDataList<T>
        where T : IFileData
    {
    }
}
