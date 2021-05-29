<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Manifacturers;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IManifacturerData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
