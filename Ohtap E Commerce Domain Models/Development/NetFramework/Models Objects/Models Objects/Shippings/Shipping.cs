﻿using Ohtap.ECommerce.Domain.Models.Objects.Cargos;
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
        public virtual IPaymentData Payment { get; set; }
        public virtual ICargoData Cargo { get; set; }
    }
}