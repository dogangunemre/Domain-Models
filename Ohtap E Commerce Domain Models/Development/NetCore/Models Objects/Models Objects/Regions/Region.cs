using Ohtap.ECommerce.Domain.Models.Objects.Products;
using Ohtap.ECommerce.Domain.Models.Objects.RegionDetails;
using Ohtap.ECommerce.Domain.Models.Objects.Taxes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Regions
{
    public class Region : RegionBasic, IRegion
    {
        private RegionList _Childs;
        public virtual RegionList Childs { get => base.GetProperty(this._Childs); set => base.SetProperty(ref this._Childs, value); }
        IRegionDataList<IRegionData> IRegion.Childs { get { return this.Childs as IRegionDataList<IRegionData>; } set { this.Childs = (RegionList)value; } }


        private RegionDetailList _Details;
        public virtual RegionDetailList Details { get => base.GetProperty(this._Details); set => base.SetProperty(ref this._Details, value); }
        IRegionDetailDataList<IRegionDetailData> IRegion.Details { get { return this.Details as IRegionDetailDataList<IRegionDetailData>; } set { this.Details = (RegionDetailList)value; } }

        private Tax _Tax;
        public virtual Tax Tax { get => base.GetProperty(this._Tax); set => base.SetProperty(ref this._Tax, value); }
        ITaxData IRegion.Tax { get { return this.Tax as ITaxData; } set { this.Tax = (Tax)value; } }

    }
}
