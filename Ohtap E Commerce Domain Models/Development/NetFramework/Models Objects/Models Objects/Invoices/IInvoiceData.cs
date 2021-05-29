using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.Invoices
{
    public interface IInvoiceData :  CoreObject.IObjectID, CoreObject.IObjectTitle, CoreObject.IObjectOrder, CoreObject.IObjectDescription, CoreObject.IObjectState, IInvoiceTotalPrice, IInvoiceDate
    {

    }
}
