﻿using Ohtap.ECommerce.Domain.Models.Objects.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.PackageAttributes
{
    public class PackageAttributeBasic : IPackageAttributeData
    {
        public virtual string ID { get; set; }
        public virtual int Order { get; set; }
        public virtual string Description { get; set; }
        public virtual int State { get; set; }
        public virtual string Value { get; set; }
        public virtual IAttributeData Attribute { get; set; }
    }
}
