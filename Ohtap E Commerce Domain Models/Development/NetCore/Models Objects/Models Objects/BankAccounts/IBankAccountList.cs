using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.BankAccounts
{
    public interface IBankAccountList<T> : IBankAccountDataList<T>
        where T : IBankAccountData
    {
    }
}
