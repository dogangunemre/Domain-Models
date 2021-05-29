<?php

namespace Ohtap\ECommerce\DomainModels\Objects\SpecificationDetails;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface ISpecificationDetailData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
