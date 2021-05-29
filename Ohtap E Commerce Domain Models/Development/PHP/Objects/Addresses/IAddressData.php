<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Addresses;
use Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IAddressData extends IAddressFullAddress,IAddressCity,IAddressCountry,IAddressPostCode,  CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{


}