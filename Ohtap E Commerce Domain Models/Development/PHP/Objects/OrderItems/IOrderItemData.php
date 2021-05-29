<?php

namespace Ohtap\ECommerce\DomainModels\Objects\OrderItems;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IOrderItemData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
