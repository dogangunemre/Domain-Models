﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Cargos
{
    public interface ICargo : ICargoData
    {
        Addresses.IAddressData Address { get; set; }
    }
}
