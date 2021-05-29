using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Tags.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Tags.Objects
{
    public class TagIdentity : Objecta, ITagIdentity
    {
        private string _ID;
        public virtual string ID { get => base.GetProperty(this._ID); set => base.SetProperty(ref this._ID, value); }
    }
}
