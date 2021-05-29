<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Warehouses;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IWarehouseData extends IWarehouseStore,IWarehouseAddress,IWarehouseEmail,IWarehouseFax,IWarehousePhone,CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
