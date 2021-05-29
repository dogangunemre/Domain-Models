using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Brands
{
    public interface IBrandLogo
    {
        Files.IFileData Logo { get; set; }
    }
}
