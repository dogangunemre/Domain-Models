using Ohtap.ECommerce.Domain.Models.Core.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Tags.Interfaces
{
    public interface ITagBasic : IObjectBasic, ITagInfo
    {
        string Symbol { get; set; }
        string FundCode { get; set; }
    }
}
