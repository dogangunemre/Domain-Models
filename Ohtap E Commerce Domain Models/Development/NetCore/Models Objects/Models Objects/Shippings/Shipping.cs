using Ohtap.ECommerce.Domain.Models.Objects.Cargos;
using Ohtap.ECommerce.Domain.Models.Objects.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Shippings
{
    public class Shipping : ShippingBasic, IShipping
    {


        private Payment _Payment;
        public virtual Payment Payment { get => base.GetProperty(this._Payment); set => base.SetProperty(ref this._Payment, value); }
        IPaymentData IShipping.Payment { get { return this.Payment as IPayment; } set { this.Payment = (Payment)value; } }


        

    }
}
