using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.MeasureDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Units;

namespace Ohtap.ECommerce.Domain.Models.Objects.Measures
{
    public class Measure : MeasureBasic, IMeasure
    {
        private UnitList _Units;
        public virtual UnitList Units { get => base.GetProperty(this._Units); set => base.SetProperty(ref this._Units, value); }
        IUnitDataList<IUnitData> IMeasure.Units { get { return this.Units as IUnitDataList<IUnitData>; } set { this.Units = (UnitList)value; } }

        private MeasureDetailList _Details;
        public virtual MeasureDetailList Details { get => base.GetProperty(this._Details); set => base.SetProperty(ref this._Details, value); }
        IMeasureDetailDataList<IMeasureDetailData> IMeasure.Details { get { return this.Details as IMeasureDetailDataList<IMeasureDetailData>; } set { this.Details = (MeasureDetailList)value; } }
    }
}
