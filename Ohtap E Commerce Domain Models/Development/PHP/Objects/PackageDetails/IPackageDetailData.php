<?php

namespace Ohtap\ECommerce\DomainModels\Objects\PackageDetails;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IPackageDetailData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
