<?php

namespace Ohtap\ECommerce\DomainModels\Objects\PackageLabels;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IPackageLabelData extends IPackageLabel,IPackageLabelValue,CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
