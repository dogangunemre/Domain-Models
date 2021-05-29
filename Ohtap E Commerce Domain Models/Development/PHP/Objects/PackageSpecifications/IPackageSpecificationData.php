<?php

namespace Ohtap\ECommerce\DomainModels\Objects\PackageSpecifications;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IPackageSpecificationData extends IPackageSpecificationSpecification,IPackageSpecificationValue,CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
