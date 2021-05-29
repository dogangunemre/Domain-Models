<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Stores;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IStoreData extends IStoreEmail,IStoreFax,IStorePhone, CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
