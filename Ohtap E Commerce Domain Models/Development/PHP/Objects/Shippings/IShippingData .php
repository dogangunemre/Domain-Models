<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Shippings;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IShippingData extends IShippingAddress,IShippingEmail,IShippingFax,IShippingPhone,CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
