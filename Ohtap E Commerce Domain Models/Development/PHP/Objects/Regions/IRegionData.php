<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Regions;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IRegionData extends IRegionParent,CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
