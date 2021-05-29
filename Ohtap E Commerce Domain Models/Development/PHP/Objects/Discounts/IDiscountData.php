<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Discounts;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IDiscountData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
