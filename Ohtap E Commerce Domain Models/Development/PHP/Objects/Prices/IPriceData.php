<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Prices;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IPriceData extends IPriceParent,CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
