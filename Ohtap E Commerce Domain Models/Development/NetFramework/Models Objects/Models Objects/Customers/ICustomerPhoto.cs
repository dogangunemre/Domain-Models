using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Customers
{
    public interface ICustomerPhoto
    {
        Files.IFileData Photo { get; set; }
    }
}
