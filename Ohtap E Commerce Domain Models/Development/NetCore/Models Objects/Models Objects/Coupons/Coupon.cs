using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.CouponDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Coupons
{
    public class Coupon : CouponBasic, ICoupon
    {
        private Files.File _Photo;
        public virtual Files.File Photo { get => base.GetProperty(this._Photo); set => base.SetProperty(ref this._Photo, value); }
        Files.IFileData ICoupon.Photo { get { return this.Photo as Files.IFileData; } set { this.Photo = (Files.File)value; } }

        private Customers.CustomerList _Customers;
        public virtual Customers.CustomerList Customers { get => base.GetProperty(this._Customers); set => base.SetProperty(ref this._Customers, value); }
        Customers.ICustomerDataList<Customers.ICustomerData> ICoupon.Customers { get { return this.Customers as Customers.ICustomerDataList<Customers.ICustomerData>; } set { this.Customers = (Customers.CustomerList)value; } }

        private CouponDetailList _Details;
        public virtual CouponDetailList Details { get => base.GetProperty(this._Details); set => base.SetProperty(ref this._Details, value); }
        ICouponDetailDataList<ICouponDetailData> ICoupon.Details { get { return this.Details as ICouponDetailDataList<ICouponDetailData>; } set { this.Details = (CouponDetailList)value; } }
    }
}
