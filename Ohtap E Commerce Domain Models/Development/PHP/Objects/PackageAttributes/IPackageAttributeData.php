<?php

namespace Ohtap\ECommerce\DomainModels\Objects\PackageAttributes;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IPackageAttributeData extends IPackageAttributeAttribute,IPackageAttributeValue,CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
