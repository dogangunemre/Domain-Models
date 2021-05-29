<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Promotions;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IProductAttributeData extends IProductAttributeAttribute,IProductAttributeValue,CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
