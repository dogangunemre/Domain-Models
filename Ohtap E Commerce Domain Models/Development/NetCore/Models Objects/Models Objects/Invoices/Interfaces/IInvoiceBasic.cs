using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Invoices.Interfaces
{
    public interface IInvoiceBasic : IObjectBasic, IInvoiceInfo
    {
        string Symbol { get; set; }
        string FundCode { get; set; }
    }
}
