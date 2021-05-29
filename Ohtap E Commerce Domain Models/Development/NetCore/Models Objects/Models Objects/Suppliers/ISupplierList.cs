using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Suppliers
{
    public interface ISupplierList<T> : ISupplierDataList<T>
        where T: ISupplierData
    {
    }
}
