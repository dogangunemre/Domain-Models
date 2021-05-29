<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Packages;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IPackageData extends IPackageBarcode,IPackageUnit,IPackageSKU,IPackageMeasures,IPackagePrices,IPackageProducts,CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
