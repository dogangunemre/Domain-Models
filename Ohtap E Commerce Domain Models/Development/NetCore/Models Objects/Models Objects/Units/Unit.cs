using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.UnitDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Units
{
    public class Unit : UnitBasic, IUnit
    {
    
        private UnitDetailList _Details;
        public virtual UnitDetailList Details { get => base.GetProperty(this._Details); set => base.SetProperty(ref this._Details, value); }
        IUnitDetailDataList<IUnitDetailData> IUnit.Details { get { return this.Details as IUnitDetailDataList<IUnitDetailData>; } set { this.Details = (UnitDetailList)value; } }
    }
}
