﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Shippings
{
    public interface IShippingAddress
    {
       Addresses.IAddressData Address { get; set; }
    }
}
