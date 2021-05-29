<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Specifications;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface ISpecificationData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
