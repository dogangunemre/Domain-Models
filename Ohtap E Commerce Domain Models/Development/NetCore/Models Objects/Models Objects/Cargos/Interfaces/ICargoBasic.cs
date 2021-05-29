using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Cargos.Interfaces
{
    public interface ICargoBasic : IObjectBasic, ICargoInfo
    {
        public string Fax { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
    }
}
