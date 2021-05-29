using Ohtap.ECommerce.Domain.Models.Core.System;
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

namespace Ohtap.ECommerce.Domain.Models.Objects.Customers
{
    public class CustomerBasic : Objecta, ICustomerData
    {
        private string _ID;
        public virtual string ID { get => base.GetProperty(this._ID); set => base.SetProperty(ref this._ID, value); }

        private string _Code;
        public virtual string Code { get => base.GetProperty(this._Code); set => base.SetProperty(ref this._Code, value); }

        private string _Name;
        public virtual string Name { get => base.GetProperty(this._Name); set => base.SetProperty(ref this._Name, value); }

        private int _Order;
        public virtual int Order { get => base.GetProperty(this._Order); set => base.SetProperty(ref this._Order, value); }


        private string _Description;
        public virtual string Description { get => base.GetProperty(this._Description); set => base.SetProperty(ref this._Description, value); }

        private int _State;
        public virtual int State { get => base.GetProperty(this._State); set => base.SetProperty(ref this._State, value); }



        private string _EMail;
        public virtual string EMail { get => base.GetProperty(this._EMail); set => base.SetProperty(ref this._EMail, value); }

        

        private string _Phone;
        public virtual string Phone { get => base.GetProperty(this._Phone); set => base.SetProperty(ref this._Phone, value); }


        private string _CitizenNumber;
        public virtual string CitizenNumber { get => base.GetProperty(this._CitizenNumber); set => base.SetProperty(ref this._CitizenNumber, value); }

        private string _Gender;
        public virtual string Gender { get => base.GetProperty(this._Gender); set => base.SetProperty(ref this._Gender, value); }

        private long _DateOfBirth;
        public virtual long DateOfBirth { get => base.GetProperty(this._DateOfBirth); set => base.SetProperty(ref this._DateOfBirth, value); }

        private string _Nationality;
        public virtual string Nationality { get => base.GetProperty(this._Nationality); set => base.SetProperty(ref this._Nationality, value); }

        private string _LastName;
        public virtual string LastName { get => base.GetProperty(this._LastName); set => base.SetProperty(ref this._LastName, value); }

        private File _Photo;
        public virtual File Photo { get => base.GetProperty(this._Photo); set => base.SetProperty(ref this._Photo, value); }
        IFileData ICustomerData.Photo { get { return this.Photo as Files.IFileData; } set { this.Photo = (Files.File)value; } }

        private CurrencyList _Currencies;
        public virtual CurrencyList Currencies { get => base.GetProperty(this._Currencies); set => base.SetProperty(ref this._Currencies, value); }
        ICurrencyDataList<ICurrencyData> ICustomerData.Currencies { get { return this.Currencies as ICurrencyDataList<ICurrencyData>; } set { this.Currencies = (CurrencyList)value; } }


        private AddressList _Addresses;
        public virtual AddressList Addresses { get => base.GetProperty(this._Addresses); set => base.SetProperty(ref this._Addresses, value); }
        IAddressDataList<IAddressData> ICustomerData.Addresses { get { return this.Addresses as IAddressDataList<IAddressData>; } set { this.Addresses = (AddressList)value; } }


        private DiscountList _Discounts;
        public virtual DiscountList Discounts { get => base.GetProperty(this._Discounts); set => base.SetProperty(ref this._Discounts, value); }
        IDiscountDataList<IDiscountData> ICustomerData.Discounts { get { return this.Discounts as IDiscountDataList<IDiscountData>; } set { this.Discounts = (DiscountList)value; } }

        private CouponList _Coupons;
        public virtual CouponList Coupons { get => base.GetProperty(this._Coupons); set => base.SetProperty(ref this._Coupons, value); }
        ICouponDataList<ICouponData> ICustomerData.Coupons { get { return this.Coupons as ICouponDataList<ICouponData>; } set { this.Coupons = (CouponList)value; } }



        private DataItemList _Dataset;
        public virtual DataItemList Dataset { get => base.GetProperty(this._Dataset); set => base.SetProperty(ref this._Dataset, value); }
        IDataItemList<IDataItemData> ICustomerData.Dataset { get { return this.Dataset as IDataItemList<IDataItemData>; } set { this.Dataset = (DataItemList)value; } }

        public CustomerBasic()
        {
            this.Dataset = new DataItemList();
        }
    }
}
