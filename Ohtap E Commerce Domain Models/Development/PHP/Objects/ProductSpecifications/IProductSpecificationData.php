<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Promotions;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IProductSpecificationData extends IProductSpecificationSpecification,IProductSpecificationValue,CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
