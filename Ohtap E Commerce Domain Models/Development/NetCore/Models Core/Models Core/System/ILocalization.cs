using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Core.System
{
    public interface ILocalization<T> : IObjecta
        where T : IObjecta
    {
        string Region { get; set; }
        T Content { get; set; }
    }
}
