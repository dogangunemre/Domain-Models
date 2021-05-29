using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Files.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Files.Objects
{
    public class FileItemList<T> : Lista<T>, IFileItemList<T>
        where T : IFileIdentity
    {
    }
}
