﻿using Ohtap.ECommerce.Domain.Models.Serializable.Objects.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ohtap.ECommerce.Domain.Models.Objects.Options;
using Ohtap.ECommerce.Domain.Models.Objects.PackageOptions;

namespace Ohtap.ECommerce.Domain.Models.Serializable.Objects.PackageOptions
{
    public class PackageOptionBasic : IPackageOptionData
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public string Value { get; set; }
        public IOptionData Option { get; set; }
    }
}
