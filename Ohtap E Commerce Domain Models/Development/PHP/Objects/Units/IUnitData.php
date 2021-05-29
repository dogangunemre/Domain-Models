<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Units;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IUnitData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
