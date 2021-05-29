using Ohtap.ECommerce.Domain.Models.Objects.Addresses;
using Ohtap.ECommerce.Domain.Models.Objects.Coupons;
using Ohtap.ECommerce.Domain.Models.Objects.Currencies;
using Ohtap.ECommerce.Domain.Models.Objects.Datasets;
using Ohtap.ECommerce.Domain.Models.Objects.Discounts;
using Ohtap.ECommerce.Domain.Models.Objects.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.Customers
{
    public interface ICustomerData : CoreObject.IObjectID, CoreObject.IObjectCode, CoreObject.IObjectName, CoreObject.IObjectOrder, CoreObject.IObjectDescription, CoreObject.IObjectState, ICustomerCitizenNumber, ICustomerGender, ICustomerPhone, ICustomerEMail, ICustomerDateOfBirth, ICustomerNationality,ICustomerLastName
    {
        IFileData Photo { get; set; }
        ICurrencyDataList<ICurrencyData> Currencies { get; set; }
        IAddressDataList<IAddressData> Addresses { get; set; }
        IDiscountDataList<IDiscountData> Discounts { get; set; }
        ICouponDataList<ICouponData> Coupons { get; set; }


        IDataItemList<IDataItemData> Dataset { get; set; }
    }
}
