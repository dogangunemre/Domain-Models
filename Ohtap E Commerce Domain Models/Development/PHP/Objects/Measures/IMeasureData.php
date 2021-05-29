<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Measures;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IMeasureData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
