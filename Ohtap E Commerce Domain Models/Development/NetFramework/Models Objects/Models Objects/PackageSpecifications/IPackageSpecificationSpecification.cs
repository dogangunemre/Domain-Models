﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.PackageSpecifications
{
   public  interface IPackageSpecificationSpecification
    {
        Specifications.ISpecification Specification { get; set; }
    }
}
