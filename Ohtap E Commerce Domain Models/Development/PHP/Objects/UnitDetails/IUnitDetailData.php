<?php

namespace Ohtap\ECommerce\DomainModels\Objects\UnitDetails;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IUnitDetailData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
