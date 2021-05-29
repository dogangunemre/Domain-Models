using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.PaymentStatuses
{
    public interface IPaymentStatusList<T> : IPaymentStatusDataList<T>
        where T : IPaymentStatusData
    {
    }
}
