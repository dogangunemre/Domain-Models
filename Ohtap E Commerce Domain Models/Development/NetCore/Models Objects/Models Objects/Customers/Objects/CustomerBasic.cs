using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Customers.Interfaces;
using Ohtap.ECommerce.Domain.Models.Objects.Files.Interfaces;
using Ohtap.ECommerce.Domain.Models.Objects.Regions;
using Ohtap.ECommerce.Domain.Models.Objects.Files;
using System;
using System.Collections.Generic;
using System.Text;


namespace Ohtap.ECommerce.Domain.Models.Objects.Customers.Objects
{
    public class CustomerBasic : CustomerInfo, ICustomerBasic
    {
        private int _Order;
        public virtual int Order { get => base.GetProperty(this._Order); set => base.SetProperty(ref this._Order, value); }

        private string _Description;
        public virtual string Description { get => base.GetProperty(this._Description); set => base.SetProperty(ref this._Description, value); }

        private int _State;
        public virtual int State { get => base.GetProperty(this._State); set => base.SetProperty(ref this._State, value); }

        private string _Phone;
        public virtual string Phone { get => base.GetProperty(this._Phone); set => base.SetProperty(ref this._Phone, value); }

        private string _EMail;
        public virtual string EMail { get => base.GetProperty(this._EMail); set => base.SetProperty(ref this._EMail, value); }

        private string _CitizenNumber;
        public virtual string CitizenNumber { get => base.GetProperty(this._CitizenNumber); set => base.SetProperty(ref this._CitizenNumber, value); }

        private string _Gender;
        public virtual string Gender { get => base.GetProperty(this._Gender); set => base.SetProperty(ref this._Gender, value); }

        private long _DateOfBirth;
        public virtual long DateOfBirth { get => base.GetProperty(this._DateOfBirth); set => base.SetProperty(ref this._DateOfBirth, value); }

        private string _Nationality;
        public virtual string Nationality { get => base.GetProperty(this._Nationality); set => base.SetProperty(ref this._Nationality, value); }

        private string _Name;
        public virtual string Name { get => base.GetProperty(this._Name); set => base.SetProperty(ref this._Name, value); }

        private string _LastName;
        public virtual string LastName { get => base.GetProperty(this._LastName); set => base.SetProperty(ref this._LastName, value); }

        private File _Photo;
        public virtual File Photo { get => base.GetProperty(this._Photo); set => base.SetProperty(ref this._Photo, value); }
        


        private RegionBasic _Region;
        public virtual RegionBasic Region { get => GetProperty(this._Region); set => base.SetProperty(ref this._Region, value); }
        RegionBasic ICustomerBasic.Region { get { return this.Region as RegionBasic; } set { this.Region = (Region)value; } }


    }
}
