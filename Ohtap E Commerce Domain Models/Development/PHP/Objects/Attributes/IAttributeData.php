<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Attributes;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IAttributeData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
