<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Orders;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IOrderData extends IOrdertTotalPrice,IOrderNote,IOrderStore,CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
