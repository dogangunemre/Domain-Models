using Ohtap.ECommerce.Domain.Models.Objects.Customers;
using Ohtap.ECommerce.Domain.Models.Objects.Files;
using Ohtap.ECommerce.Domain.Models.Objects.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Invoices
{
    public class Invoice : InvoiceBasic, IInvoice
    {
        private Customer _Customer;
        public  virtual Customer Customer { get => base.GetProperty(this._Customer); set => base.SetProperty(ref this._Customer, value); }
        ICustomerData IInvoice.Customer { get { return this.Customer as ICustomerData; } set { this.Customer = (Customer)value; } }

        private File _Photo;
        public virtual File Photo { get => base.GetProperty(this._Photo); set => base.SetProperty(ref this._Photo, value); }
        IFileData IInvoice.Photo { get { return this.Photo as Files.IFileData; } set { this.Photo = (Files.File)value; } }
    }
}
