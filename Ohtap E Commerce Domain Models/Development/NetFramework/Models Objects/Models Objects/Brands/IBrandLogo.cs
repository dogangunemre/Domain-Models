using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Files;

namespace Ohtap.ECommerce.Domain.Models.Objects.Brands
{
    public interface IBrandLogo
    {
        IFileData Logo { get; set; }
    }
}
