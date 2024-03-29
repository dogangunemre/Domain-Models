﻿using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Authentications.Interfaces
{
    public interface IAuthenticationBasic : IObjectBasic, IAuthenticationInfo
    {
        string Symbol { get; set; }
        string FundCode { get; set; }
    }
}
