using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Relations.Interfaces
{
    public interface IRelationBasic : IObjectBasic, IRelationInfo
    {
        string Symbol { get; set; }
        string FundCode { get; set; }
    }
}
