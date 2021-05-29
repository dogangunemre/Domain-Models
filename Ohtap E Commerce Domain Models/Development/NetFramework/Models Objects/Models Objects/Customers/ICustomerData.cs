using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreObject = Ohtap.ECommerce.Domain.Models.Core.Object;

namespace Ohtap.ECommerce.Domain.Models.Objects.Customers
{
    public interface ICustomerData :  CoreObject.IObjectID, CoreObject.IObjectCode, CoreObject.IObjectName, CoreObject.IObjectOrder, CoreObject.IObjectDescription, CoreObject.IObjectState, ICustomerCitizenNumber, ICustomerGender, ICustomerPhoto, ICustomerPhone, ICustomerEMail, ICustomerDateOfBirth, ICustomerNationality
    {

    }
}
