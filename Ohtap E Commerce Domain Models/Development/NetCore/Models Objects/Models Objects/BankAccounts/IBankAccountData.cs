using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Objects.Banks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.BankAccounts
{
    public interface IBankAccountData : CoreObject.IObjectID, CoreObject.IObjectCode, CoreObject.IObjectName, CoreObject.IObjectOrder, CoreObject.IObjectDescription, CoreObject.IObjectState, IBankAccountBranch, IBankAccountNumber, IBankAccountIBAN, IBankAccountSwiftCode, IBankAccountType
    {
        IBankData Bank { get; set; }
        IDataItemList<IDataItemData> Dataset { get; set; }
    }
}
